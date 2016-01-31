// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Solution.MEF;
using Xrm.Solution.Common;
using Xrm.Solution.Configuration;

namespace Xrm.Solution.Utility
{
    /// <summary>
    ///     Class XrmHelperAndUtilityFunctions.
    /// </summary>
    public static class XrmMetadataHelperFunctions
    {
        /// <summary>
        ///     Adds to solution.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="solutionName">Name of the solution.</param>
        /// <param name="componentType">Type of the component.</param>
        /// <param name="metadataId">The metadata identifier.</param>
        public static void AddToSolution(IOrganizationService crmService, string solutionName,
            ComponentType componentType, Guid metadataId)
        {
            try
            {
                var addReq = new AddSolutionComponentRequest
                {
                    ComponentType = (int) componentType,
                    ComponentId = metadataId,
                    SolutionUniqueName = solutionName.ToUniqueName()
                };

                crmService.Execute(addReq);
            }
            catch (FaultException<OrganizationServiceFault> orgex)
            {
                orgex.Message.TraceVerbose(orgex);
            }
        }

        /// <summary>
        ///     Adds to solutions.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="solutions">The solutions.</param>
        /// <param name="componentType">Type of the component.</param>
        /// <param name="metadataId">The metadata identifier.</param>
        /// <param name="recreateSolutionIfExist">if set to <c>true</c> [recreate solution if exist].</param>
        public static void AddToSolutions(IOrganizationService crmService, SolutionElementCollection solutions,
            ComponentType componentType, Guid metadataId, bool recreateSolutionIfExist = false)
        {
            lock (solutions)
            {
                foreach (SolutionElement solution in solutions)
                {
                    var uniqueName = solution.Name.ToUniqueName();
                    var xrmSolution = XrmHelperFunctions.GetXrmSolution(uniqueName, crmService);

                    if (xrmSolution != null && recreateSolutionIfExist)
                    {
                        crmService.Delete(EntityName.solution, xrmSolution.Id);
                        xrmSolution = null;
                    }

                    if (xrmSolution == null)
                    {
                        XrmHelperFunctions.CreateSolution(crmService,
                            Guid.NewGuid(),
                            uniqueName,
                            solution.Name,
                            solution.Name,
                            Convert.ToDouble(solution.Version));
                    }

                    if (metadataId == Guid.Empty) return;
                    "adding {0} >> {1}".Trace(metadataId, uniqueName);

                    bool addToSolution = (solution.ExportWorkflows && componentType == ComponentType.Workflow)
                                         ||
                                         (solution.ExportPlugins &&
                                          (componentType == ComponentType.PluginAssembly ||
                                           componentType == ComponentType.SdkMessageProcessingStep))
                                         ||
                                         (solution.ExportSecurityRoles && componentType == ComponentType.Role ||
                                          componentType == ComponentType.FieldSecurityProfile)
                                         || (solution.ExportWebresources && componentType == ComponentType.WebResource)
                                         || (solution.ExportEntities && 
                                         (componentType == ComponentType.Entity ||
                                          componentType == ComponentType.ConnectionRole ||
                                          componentType == ComponentType.ContractTemplate ||
                                          componentType == ComponentType.OptionSet ||
                                          componentType == ComponentType.Report ||
                                          componentType == ComponentType.KbArticleTemplate ||
                                          componentType == ComponentType.EmailTemplate ||
                                          componentType == ComponentType.MailMergeTemplate ||
                                          componentType == ComponentType.SystemForm));

                    if (addToSolution) AddToSolution(crmService, uniqueName, componentType, metadataId);
                }
            }
        }

        /// <summary>
        ///     Converts to XML.
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize.</param>
        /// <returns>System.String.</returns>
        public static string ConvertToXml(object objectToSerialize)
        {
            if (objectToSerialize == null)
                return "<object></object>";

            var xmlBuilder = new StringBuilder();

            using (var xmlWriter = XmlWriter.Create(xmlBuilder))
            {
                var xmlSerializer = new DataContractSerializer(objectToSerialize.GetType());
                xmlSerializer.WriteObject(xmlWriter, objectToSerialize);
            }

            return xmlBuilder.ToString();
        }

        /// <summary>
        ///     Finds the difference between objects.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="logicalName">The logical name</param>
        /// <param name="componentType">Type of the component.</param>
        /// <param name="context">The context.</param>
        /// <returns><c>true</c> if source is different, <c>false</c> otherwise.</returns>
        public static bool FindDifferenceBetweenObjects(object source,
            object destination,
            string logicalName,
            ComponentType componentType,
            XrmActivityContext context)
        {
            var xmlDocumentSource = new XmlDocument();
            xmlDocumentSource.LoadXml(ConvertToXml(source));

            var xmlDocumentDestination = new XmlDocument();
            xmlDocumentDestination.LoadXml(ConvertToXml(destination));

            var diff = new DiffXrmXml();

            var changeList = diff.GetDifference(xmlDocumentSource.DocumentElement,
                xmlDocumentDestination.DocumentElement, DiffXrmXml.Exceptions);

            var diffItems = changeList as IList<DiffItem> ?? changeList.ToList();

            context.ChangeList = context.ChangeList ??
                                 new Dictionary<KeyValuePair<string, ComponentType>, List<DiffItem>>();

            context.ChangeList[new KeyValuePair<string, ComponentType>(logicalName, componentType)] = diffItems.ToList();

            return diffItems.Any(c => c.DiffType == DiffType.Added || c.DiffType == DiffType.Edited);
        }

        /// <summary>
        ///     Gets all entity metadata.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="filters">The filters.</param>
        /// <returns>EntityMetadata[].</returns>
        public static EntityMetadata[] GetAllEntityMetadata(IOrganizationService crmService, EntityFilters filters)
        {
            return GetEntityMetatadata<RetrieveAllEntitiesResponse>(crmService, null, filters).EntityMetadata;
        }

        /// <summary>
        ///     Gets all entity metadata dictionary.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="filters">The filters.</param>
        /// <returns>Dictionary&lt;System.String, EntityMetadata&gt;.</returns>
        public static Dictionary<string, EntityMetadata> GetAllEntityMetadataDictionary(IOrganizationService crmService,
            EntityFilters filters)
        {
            return
                GetEntityMetatadata<RetrieveAllEntitiesResponse>(crmService, null, filters)
                    .EntityMetadata.OrderBy(c => c.LogicalName).ToDictionary(c => c.LogicalName);
        }

        /// <summary>
        ///     Gets all option set metadata.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <returns>Dictionary&lt;System.String, OptionSetMetadataBase&gt;.</returns>
        public static Dictionary<string, OptionSetMetadataBase> GetAllOptionSetMetadata(IOrganizationService crmService)
        {
            var request = new RetrieveAllOptionSetsRequest
            {
                RetrieveAsIfPublished = true
            };

            return
                ((RetrieveAllOptionSetsResponse) crmService.Execute(request)).OptionSetMetadata.Where(
                    c => c.IsGlobal != null && c.IsGlobal.Value).ToDictionary(c => c.Name);
        }

        /// <summary>
        ///     Gets the attribute collection.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityLogicalName">Name of the entity logical.</param>
        /// <param name="filters">The filters.</param>
        /// <returns>Dictionary&lt;System.String, AttributeMetadata&gt;.</returns>
        public static Dictionary<string, AttributeMetadata> GetAttributeCollection(IOrganizationService crmService,
            string entityLogicalName, EntityFilters filters)
        {
            var response = GetEntityMetatadata<RetrieveEntityResponse>(crmService, entityLogicalName,
                EntityFilters.Attributes);
            return response?.EntityMetadata.Attributes.ToDictionary(c => c.LogicalName) ?? new Dictionary<string, AttributeMetadata>();
        }

        /// <summary>
        ///     Gets the dashboards.
        /// </summary>
        /// <param name="crmSerivce">The CRM serivce.</param>
        /// <returns>Entity[].</returns>
        public static Dictionary<Guid, Entity> GetDashboards(IOrganizationService crmSerivce)
        {
            var formCollection = XrmHelperFunctions.RetrieveMultiple(crmSerivce,
                EntityName.systemform,
                new ConditionExpression(systementity.type, ConditionOperator.Equal, (int) SystemFormType.Dashboard));

            return formCollection.ToDictionary(c => c.Id);
        }

        /// <summary>
        ///     Gets the entity metadata.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityLogicalName">Name of the entity logical.</param>
        /// <param name="filters">The filters.</param>
        /// <returns>EntityMetadata[].</returns>
        public static EntityMetadata[] GetEntityMetadata(IOrganizationService crmService, string entityLogicalName,
            EntityFilters filters)
        {
            var metadata = GetEntityMetatadata<RetrieveEntityResponse>(crmService, entityLogicalName, filters);
            return metadata != null ? new[] {metadata.EntityMetadata} : new EntityMetadata[] {};
        }

        /// <summary>
        ///     Gets the entity metadata.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityLogicalNames">The entity logical names.</param>
        /// <param name="filters">The filters.</param>
        /// <returns>EntityMetadata[].</returns>
        public static EntityMetadata[] GetEntityMetadata(IOrganizationService crmService, string[] entityLogicalNames,
            EntityFilters filters)
        {
            var metadata = new EntityMetadata[entityLogicalNames.Length];

            for (var index = 0; index < entityLogicalNames.Length; index++)
            {
                metadata[index] =
                    GetEntityMetatadata<RetrieveEntityResponse>(crmService, entityLogicalNames[index].Trim(), filters)
                        .EntityMetadata;
            }

            return metadata;
        }

        /// <summary>
        ///     Gets the entity metadata
        /// </summary>
        /// <typeparam name="TResponse">The type of response</typeparam>
        /// <param name="crmService">CRM Organization service</param>
        /// <param name="entityLogicalName">The logical name of the entity</param>
        /// <param name="filters">Entity filter</param>
        /// <returns>TResponse.</returns>
        public static TResponse GetEntityMetatadata<TResponse>(IOrganizationService crmService, string entityLogicalName,
            EntityFilters filters)
            where TResponse : OrganizationResponse
        {
            try
            {
                OrganizationRequest request;
                if (!string.IsNullOrEmpty(entityLogicalName))
                {
                    request = new RetrieveEntityRequest
                    {
                        EntityFilters = filters,
                        LogicalName = entityLogicalName,
                        RetrieveAsIfPublished = true
                    };
                }
                else
                {
                    request = new RetrieveAllEntitiesRequest
                    {
                        EntityFilters = filters,
                        RetrieveAsIfPublished = true
                    };
                }

                return (TResponse) crmService.Execute(request);
            }
            catch (FaultException<OrganizationServiceFault> orgex)
            {
                orgex.Message.Trace();
            }

            return null;
        }

        /// <summary>
        ///     Gets the entity primary id and name column
        /// </summary>
        /// <param name="crmService">The CRM organization service</param>
        /// <param name="entityLogicalName">The entity logical name</param>
        /// <returns>A key value pair of the primary id and the column</returns>
        public static KeyValuePair<string, string> GetEntityPrimaryColumns(IOrganizationService crmService,
            string entityLogicalName)
        {
            var response = GetEntityMetatadata<RetrieveEntityResponse>(crmService, entityLogicalName,
                EntityFilters.Entity);

            return response == null
                ? new KeyValuePair<string, string>(null, null)
                : new KeyValuePair<string, string>(response.EntityMetadata.PrimaryIdAttribute,
                    response.EntityMetadata.PrimaryNameAttribute);
        }

        /// <summary>
        ///     Gets the non system columns.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityLogicalName">Name of the entity logical.</param>
        /// <param name="exceptions">The exceptions.</param>
        /// <returns>System.String[].</returns>
        public static string[] GetNonSystemColumns(IOrganizationService crmService,
            string entityLogicalName, params string[] exceptions)
        {
            var columnList = new List<string>();
            var response = GetEntityMetatadata<RetrieveEntityResponse>(crmService, entityLogicalName,
                EntityFilters.Attributes);

            if (response == null) return columnList.ToArray();
            foreach (var attribute in response.EntityMetadata.Attributes)
            {
                if (attribute.AttributeType == AttributeTypeCode.EntityName
                    || attribute.AttributeType == AttributeTypeCode.DateTime
                    || attribute.AttributeType == AttributeTypeCode.Lookup
                    || attribute.AttributeType == AttributeTypeCode.State
                    || attribute.AttributeType == AttributeTypeCode.Status
                    || attribute.AttributeType == AttributeTypeCode.Owner) continue;

                if (!string.IsNullOrEmpty(attribute.AttributeOf)) continue;
                if (attribute.IsValidForRead != null && !attribute.IsValidForRead.Value) continue;

                var exceptionFound = exceptions.Any(c => attribute.LogicalName.EndsWith(c));
                if (exceptionFound) continue;

                columnList.Add(attribute.LogicalName);
            }

            return columnList.ToArray();
        }

        /// <summary>
        ///     Gets the system form.
        /// </summary>
        /// <param name="crmSerivce">The CRM serivce.</param>
        /// <param name="metadata">The metadata.</param>
        /// <returns>IEnumerable&lt;Entity&gt;.</returns>
        public static List<string> GetSystemForm(IOrganizationService crmSerivce,
            EntityMetadata metadata)
        {
            var formCollection = XrmHelperFunctions.RetrieveMultiple(crmSerivce,
                EntityName.systemform,
                new ConditionExpression(systementity.objecttypecode, ConditionOperator.Equal, metadata.ObjectTypeCode),
                new ConditionExpression(systementity.type, ConditionOperator.GreaterThan, (int) SystemFormType.Dashboard));

            return
                formCollection.Where(c => c.Attributes.Contains("formxml"))
                    .Select(c => (string) c.Attributes["formxml"])
                    .ToList();
        }

        /// <summary>
        ///     Gets the type of the web resource.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <returns>WebResourceType.</returns>
        public static WebResourceType GetWebResourceType(string extension)
        {
            switch (extension)
            {
                case ".js":
                    return WebResourceType.Script;
                case ".html":
                    return WebResourceType.Webpage;
                case ".htm":
                    return WebResourceType.Webpage;
                case ".css":
                    return WebResourceType.StyleSheetCss;
                case ".xml":
                    return WebResourceType.Data;
                case ".png":
                    return WebResourceType.ImagePng;
                case ".jpg":
                    return WebResourceType.ImageJpg;
                case ".gif":
                    return WebResourceType.ImageGif;
                case ".xap":
                    return WebResourceType.Silverlight;
                case ".xsl":
                    return WebResourceType.StyleSheet;
                case ".xslt":
                    return WebResourceType.StyleSheet;
                case ".ico":
                    return WebResourceType.ImageIco;
            }

            return WebResourceType.Data;
        }


        /// <summary>
        ///     Processes the task.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="sourceList">The source list.</param>
        /// <param name="getXrmConnection">The get XRM connection.</param>
        /// <param name="execute">The execute.</param>
        /// <param name="exit">The exit.</param>
        /// <param name="threads">The threads.</param>
        public static void ProcessTask<TKey, TValue>(Dictionary<TKey, TValue> sourceList,
            Func<IOrganizationService[]> getXrmConnection,
            Action<TValue, IOrganizationService[]> execute,
            Action exit,
            int threads)
        {
            Parallel.ForEach(sourceList,
                new ParallelOptions { MaxDegreeOfParallelism = threads },
                getXrmConnection,
                (e, loopState, index, proxy) =>
                {
                    execute?.Invoke(e.Value, proxy);
                    return proxy;
                },
                proxy =>
                {
                    exit?.Invoke();
                });
        }

        /// <summary>
        ///     Processes the task.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="sourceList">The source list.</param>
        /// <param name="getXrmConnection">The get XRM connection.</param>
        /// <param name="execute">The execute.</param>
        /// <param name="exit">The exit.</param>
        /// <param name="threads">The threads.</param>
        public static void ProcessTask<TKey, TValue>(Dictionary<TKey, TValue> sourceList,
            Func<IOrganizationService> getXrmConnection,
            Action<TValue, IOrganizationService> execute,
            Action exit,
            int threads)
        {
            Parallel.ForEach(sourceList,
                new ParallelOptions { MaxDegreeOfParallelism = threads},
                getXrmConnection,
                (e, loopState, index, proxy) =>
                {
                    execute?.Invoke(e.Value, proxy);
                    return proxy;
                },
                proxy =>
                {
                    exit?.Invoke();
                });
        }

        /// <summary>
        ///     Replaces all in XML.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <param name="nodeName">Name of the node.</param>
        /// <returns>System.String.</returns>
        public static string ReplaceAllInXml(this string xml, string nodeName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            var nodeStack = new Stack<XmlNode>();
            nodeStack.Push(xmlDoc.DocumentElement);

            while (nodeStack.Count != 0)
            {
                var element = nodeStack.Pop();
                var parent = element.ParentNode;

                if (string.Compare(element.Name, nodeName, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    parent?.RemoveChild(element);
                }
                else
                {
                    foreach (XmlNode childNode in element.ChildNodes)
                        nodeStack.Push(childNode);
                }
            }

            return xmlDoc.ToString();
        }
    }
}