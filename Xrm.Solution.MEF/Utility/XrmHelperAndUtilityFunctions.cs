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
using System.Xml;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Solution.MEF;
using Xrm.Solution.Common;
using Xrm.Solution.Configuration;
using Microsoft.Crm.Sdk.Messages;
using System.ServiceModel;

namespace Xrm.Solution.Utility
{
    /// <summary>
    ///     Enum CrudOperationType
    /// </summary>
    public enum CrudOperationType
    {
        /// <summary>
        ///     The create
        /// </summary>
        Create = 1,

        /// <summary>
        ///     The read
        /// </summary>
        Read = 2,

        /// <summary>
        ///     The update
        /// </summary>
        Update = 3,

        /// <summary>
        ///     The delete
        /// </summary>
        Delete = 5
    }

    /// <summary>
    ///     Class XrmHelperAndUtilityFunctions.
    /// </summary>
    public static class XrmHelperFunctions
    {
        /// <summary>
        ///     Associates the dissassociate security roles.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="roleName">Name of the role.</param>
        /// <param name="associateRecords">if set to <c>true</c> [associate records].</param>
        public static void AssociateDissassociateSecurityRoles(IOrganizationService crmService, string roleName,
            bool associateRecords)
        {
            var roles = RetrieveMultipleByEntityName(crmService, EntityName.role, true);
            var systemUserRoles = RetrieveMultipleByEntityName(crmService, EntityName.systemuserroles);

            var systemUsers = RetrieveMultipleByEntityName(crmService, EntityName.systemuser, true);

            foreach (var user in systemUsers)
            {
                var tempRoleId =
                    roles.FirstOrDefault(
                        r =>
                            string.Compare((string) r.Value[role.name], roleName, StringComparison.OrdinalIgnoreCase) ==
                            0
                            && ((EntityReference) r.Value[role.businessunitid]).Id ==
                            ((EntityReference) user.Value[systemuser.businessunitid]).Id).Key;
                try
                {
                    var isExists = systemUserRoles.Any(c => (Guid) c.Value[systemuserroles.roleid] == tempRoleId
                                                            &&
                                                            (Guid) c.Value[systemuserroles.systemuserid] == user.Key);
                    if (associateRecords && !isExists)
                    {
                        "associating role {0} with user {1}".TraceVerbose(tempRoleId, user.Key);
                        crmService.Associate(
                            EntityName.systemuser,
                            user.Key,
                            new Relationship("systemuserroles_association"),
                            new EntityReferenceCollection
                            {
                                new EntityReference(EntityName.role, tempRoleId)
                            }
                            );
                        "association successful".TraceSuccess();
                    }
                    else if (!associateRecords && isExists)
                    {
                        "Disassociating role {0} with user {1}".TraceVerbose(tempRoleId, user.Key);
                        crmService.Disassociate(
                            EntityName.systemuser,
                            user.Key,
                            new Relationship("systemuserroles_association"),
                            new EntityReferenceCollection
                            {
                                new EntityReference(EntityName.role, tempRoleId)
                            }
                            );
                        "Disassociation successful".TraceSuccess();
                    }
                }
                catch (FaultException<OrganizationServiceFault> orgex)
                {
                    orgex.Message.TraceError(orgex);
                }
            }
        }

        /// <summary>
        ///     Creates the solution.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="solutionId">The solution id</param>
        /// <param name="uniqueName">Name of the unique.</param>
        /// <param name="friendlyname">The friendlyname.</param>
        /// <param name="description">The description.</param>
        /// <param name="version">The version.</param>
        public static void CreateSolution(IOrganizationService service,
            Guid solutionId,
            string uniqueName,
            string friendlyname,
            string description,
            double version)
        {
            var query = new QueryExpression(EntityName.solution) {ColumnSet = new ColumnSet(true)};
            query.Criteria.AddCondition(solution.uniquename, ConditionOperator.Equal, uniqueName);

            var existingSolutionCollection = service.RetrieveMultiple(query);

            if (existingSolutionCollection.Entities.Count > 0) return;

            var solutionRecord = new Entity(EntityName.solution)
            {
                [solution.solutionid] = solutionId,
                [solution.uniquename] = uniqueName,
                [solution.friendlyname] = friendlyname,
                [solution.publisherid] = GetDefaultPublisher(service),
                [solution.description] = description,
                [solution.version] = version + ".0"
            };


            service.Create(solutionRecord);
        }

        /// <summary>
        ///     Enables or disable organiztion's auditing.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="enableAuditing">if set to <c>true</c> [enable auditing].</param>
        public static void EnableOrDisableAuditing(IOrganizationService crmService, bool enableAuditing)
        {
            // Enable auditing on the organization.
            // First, get the organization's ID from the system user record.
            var orgId = ((WhoAmIResponse) crmService.Execute(new WhoAmIRequest())).OrganizationId;

            // Next, retrieve the organization's record.

            // Next, retrieve the organization's record.
            var org = crmService.Retrieve(EntityName.organization, orgId,
                new ColumnSet(organization.organizationid, organization.isauditenabled));

            org[organization.isauditenabled] = enableAuditing;
            crmService.Update(org);
        }

        /// <summary>
        ///     Enables or disable plugin steps.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="enablePlugin">Enables or disables the plugin.</param>
        /// <param name="conditions">The conditions.</param>
        public static void EnableOrDisablePluginSteps(IOrganizationService crmService, bool enablePlugin,
            params ConditionExpression[] conditions)
        {
            var pluginCollection = GetPluginsSteps(crmService, conditions);

            pluginCollection.Entities.ToList().ForEach(p =>
            {
                var statecode = enablePlugin
                    ? new OptionSetValue((int) sdkmessageprocessingstep_enums.statecode.Enabled)
                    : new OptionSetValue((int) sdkmessageprocessingstep_enums.statecode.Disabled);

                var statuscode = enablePlugin
                    ? new OptionSetValue((int) sdkmessageprocessingstep_enums.statuscode.Enabled)
                    : new OptionSetValue((int) sdkmessageprocessingstep_enums.statuscode.Disabled);
                try
                {
                    crmService.Execute(new SetStateRequest
                    {
                        EntityMoniker = new EntityReference(EntityName.sdkmessageprocessingstep, p.Id),
                        State = statecode,
                        Status = statuscode
                    });
                }
                catch (FaultException<OrganizationServiceFault> orgex)
                {
                    orgex.Message.TraceError(orgex);
                }
            });
        }

        /// <summary>
        ///     Enables or disable workflow steps.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="enableWorkflow">if set to <c>true</c> [enable workflow].</param>
        /// <param name="conditions">The conditions.</param>
        public static void EnableOrDisableWorkflowSteps(IOrganizationService crmService, bool enableWorkflow,
            params ConditionExpression[] conditions)
        {
            const string fetchWorkflow =
                @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
              <entity name='workflow'>
                <attribute name='workflowid' />
                <attribute name='name' />
                <order attribute='name' descending='false' />
                <filter type='and'>
                  <condition attribute='type' operator='eq' value='1' />
                  <filter type='or'>
                    <condition attribute='category' operator='eq' value='0' />
                    <filter type='and'>
                      <condition attribute='category' operator='eq' value='1' />
                      <condition attribute='languagecode' operator='eq-userlanguage' />
                    </filter>
                  </filter>
                  <condition attribute='statecode' operator='eq' value='1' />
                </filter>
              </entity>
            </fetch>";

            var request = new FetchXmlToQueryExpressionRequest
            {
                FetchXml = fetchWorkflow
            };
            var response = crmService.Execute(request) as FetchXmlToQueryExpressionResponse;
            if (response == null) return;

            var orFilter = new FilterExpression
            {
                FilterOperator = LogicalOperator.Or
            };

            orFilter.AddCondition(workflow.name, ConditionOperator.DoesNotBeginWith, "Workflow");
            orFilter.AddCondition(workflow.name, ConditionOperator.DoesNotBeginWith, "ObjectModel");
            orFilter.Conditions.AddRange(conditions);

            response.Query.Criteria.Filters.AddRange(orFilter);

            var results = crmService.RetrieveMultiple(response.Query);
            var activatedWorkflowIds = results.Entities.ToList();

            // Enable auditing on the organization.
            // First, get the organization's ID from the system user record.
            var currentUserId = ((WhoAmIResponse) crmService.Execute(new WhoAmIRequest())).UserId;

            activatedWorkflowIds.ForEach(workflowRecord =>
            {
                try
                {
                    crmService.Execute(new AssignRequest
                    {
                        Assignee = new EntityReference(EntityName.systemuser, currentUserId),
                        Target = new EntityReference(EntityName.workflow, workflowRecord.Id)
                    });

                    var statecode = enableWorkflow
                        ? new OptionSetValue((int) sdkmessageprocessingstep_enums.statecode.Enabled)
                        : new OptionSetValue((int) sdkmessageprocessingstep_enums.statecode.Disabled);

                    var statuscode = enableWorkflow
                        ? new OptionSetValue((int) sdkmessageprocessingstep_enums.statuscode.Enabled)
                        : new OptionSetValue((int) sdkmessageprocessingstep_enums.statuscode.Disabled);

                    crmService.Execute(new SetStateRequest
                    {
                        EntityMoniker = new EntityReference(EntityName.workflow, workflowRecord.Id),
                        State = statecode,
                        Status = statuscode
                    });
                }
                catch (FaultException<OrganizationServiceFault> orgex)
                {
                    orgex.Message.TraceError(orgex);
                }
            });
        }

        /// <summary>
        ///     Gets the type of the component.
        /// </summary>
        /// <param name="solutionName">Name of the solution.</param>
        /// <returns>ComponentType.</returns>
        public static ComponentType GetComponentType(string solutionName)
        {
            var names = Enum.GetNames(typeof (ComponentType));

            for (var index = 0; index < names.Length; index++)
            {
                if (string.Compare(solutionName, names[index], StringComparison.OrdinalIgnoreCase) != 0) continue;
                return (ComponentType) Enum.GetValues(typeof (ComponentType)).GetValue(index);
            }

            return ComponentType.Entity;
        }

        /// <summary>
        ///     Gets the default publisher.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <returns>EntityReference.</returns>
        public static EntityReference GetDefaultPublisher(IOrganizationService service)
        {
            // Retrieve the Default Publisher

            var defaultPublisher = service.Retrieve(EntityName.publisher,
                new Guid(ParameterName.DefaultPublisherId),
                new ColumnSet(publisher.friendlyname));

            var referecnce = new EntityReference
            {
                Id = defaultPublisher.Id,
                LogicalName = EntityName.publisher,
                Name = publisher.friendlyname
            };

            return referecnce;
        }

        /// <summary>
        ///     Gets the items published.
        /// </summary>
        /// <param name="publishedXml">The published XML.</param>
        /// <returns>Dictionary&lt;System.String, System.String&gt;.</returns>
        public static Dictionary<string, string> GetItemsPublished(string publishedXml)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(publishedXml);

            var publishedItems = new Dictionary<string, string>();
            var stack = new Stack<XmlElement>();
            stack.Push(xmlDoc.DocumentElement);

            while (stack.Count != 0)
            {
                var element = stack.Pop();

                if (element.ChildNodes.Count == 0)
                    publishedItems[element.Name] = element.InnerXml;

                foreach (XmlElement childElement in element.ChildNodes)
                    stack.Push(childElement);
            }

            return publishedItems;
        }

        /// <summary>
        ///     Gets the plugins steps.
        /// </summary>
        /// <param name="crmSerivce">The CRM serivce.</param>
        /// <param name="conditions">The conditions.</param>
        /// <returns>EntityCollection.</returns>
        public static EntityCollection GetPluginsSteps(IOrganizationService crmSerivce,
            params ConditionExpression[] conditions)
        {
            var query = new QueryExpression
            {
                EntityName = EntityName.sdkmessageprocessingstep,
                ColumnSet = new ColumnSet(true)
            };

            query.Criteria.AddCondition(sdkmessageprocessingstep.ishidden, ConditionOperator.Equal, false);
            query.Criteria.AddCondition(sdkmessageprocessingstep.iscustomizable, ConditionOperator.Equal, true);
            query.Criteria.AddCondition(sdkmessageprocessingstep.customizationlevel, ConditionOperator.GreaterEqual, 1);

            var orFilter = new FilterExpression
            {
                FilterOperator = LogicalOperator.Or
            };

            orFilter.AddCondition(sdkmessageprocessingstep.name, ConditionOperator.DoesNotBeginWith, "Workflow");
            orFilter.AddCondition(sdkmessageprocessingstep.name, ConditionOperator.DoesNotBeginWith, "ObjectModel");
            orFilter.Conditions.AddRange(conditions);

            query.Criteria.Filters.AddRange(orFilter);
            return crmSerivce.RetrieveMultiple(query);
        }

        /// <summary>
        ///     Gets the publisher.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="uniquename">The uniquename of the publisher.</param>
        /// <returns>EntityReference.</returns>
        public static EntityReference GetPublisher(IOrganizationService service, string uniquename)
        {
            // Retrieve the Default Publisher

            var queryExpression = new QueryExpression(EntityName.publisher);
            queryExpression.Criteria.AddCondition(publisher.uniquename, ConditionOperator.Equal, uniquename);

            var publisherCollection = service.RetrieveMultiple(queryExpression);

            var publisherRecord = publisherCollection.Entities.FirstOrDefault();

            if (publisherRecord == null) return null;

            var referecnce = new EntityReference
            {
                Id = publisherRecord.Id,
                LogicalName = EntityName.publisher,
                Name = (string) publisherRecord[publisher.uniquename]
            };

            return referecnce;
        }

        /// <summary>
        ///     Gets the root business unit.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <returns>KeyValuePair&lt;Guid, System.String&gt;.</returns>
        public static KeyValuePair<Guid, string> GetRootBusinessUnit(IOrganizationService crmService)
        {
            var businessunitrecord = RetrieveIdAndNameRecords(crmService, EntityName.businessunit,
                new ConditionExpression(businessunit.parentbusinessunitid, ConditionOperator.Null)).FirstOrDefault();

            return new KeyValuePair<Guid, string>(businessunitrecord.Key,
                businessunitrecord.Value);
        }

        /// <summary>
        ///     Gets the system users.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <returns>Dictionary&lt;System.String, Entity&gt;.</returns>
        public static Dictionary<Guid, Entity> GetSystemUsers(IOrganizationService crmService)
        {
            return RetrieveMultipleByEntityName(crmService, EntityName.systemuser, false, systemuser.systemuserid,
                systemuser.fullname, systemuser.internalemailaddress);
        }

        /// <summary>
        ///     Gets the root business unit.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <returns>Dictionary&lt;Guid, System.String&gt;.</returns>
        public static Dictionary<Guid, string> GetTransactionCurrencies(IOrganizationService crmService)
        {
            return RetrieveIdAndNameRecords(crmService, EntityName.transactioncurrency);
        }

        /// <summary>
        ///     Gets the XRM solution.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="service">The service.</param>
        /// <returns>Entity.</returns>
        public static Entity GetXrmSolution(string name, IOrganizationService service)
        {
            var query = new QueryExpression(EntityName.solution);
            query.Criteria.AddCondition(solution.uniquename, ConditionOperator.Equal, name);

            return service.RetrieveMultiple(query).Entities.FirstOrDefault();
        }

        /// <summary>
        ///     Determines whether the specified element name is excempted from processing.
        /// </summary>
        /// <param name="elementName">Name of the element.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="exceptions">The exceptions.</param>
        /// <returns><c>true</c> if the specified element name is excempted from processing; otherwise, <c>false</c>.</returns>
        public static bool IsExcemptedFromProcessing(string elementName, Guid id, ExceptionElementCollection exceptions)
        {
            foreach (ExceptionElement exception in exceptions)
            {
                if (!string.IsNullOrEmpty(exception.MetadataId))
                {
                    Guid metadataId;
                    Guid.TryParse(exception.MetadataId, out metadataId);

                    if (metadataId.Equals(id)) return true;
                }

                if (!string.IsNullOrEmpty(elementName))
                {
                    return (string.Compare(elementName,
                        exception.Name, StringComparison.InvariantCultureIgnoreCase) == 0);
                }
            }

            return false;
        }

        /// <summary>
        ///     Retrieves the identifier and name records.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityLogicalName">Name of the entity logical.</param>
        /// <param name="conditions">The conditions.</param>
        /// <returns>Dictionary&lt;Guid, System.String&gt;.</returns>
        public static Dictionary<Guid, string> RetrieveIdAndNameRecords(IOrganizationService crmService,
            string entityLogicalName,
            params ConditionExpression[] conditions)
        {
            var keycolumns = XrmMetadataHelperFunctions.GetEntityPrimaryColumns(crmService, entityLogicalName);

            if (string.Compare(entityLogicalName, EntityName.systemuser, StringComparison.OrdinalIgnoreCase) == 0)
            {
                keycolumns = new KeyValuePair<string, string>(keycolumns.Key, systemuser.internalemailaddress);
            }

            var query = new QueryExpression(entityLogicalName)
            {
                ColumnSet = new ColumnSet(keycolumns.Key, keycolumns.Value)
            };
            query.Criteria.Conditions.AddRange(conditions);

            return
                crmService.RetrieveMultiple(query)
                    .Entities.Where(c => c.Contains(keycolumns.Value))
                    .ToDictionary(c => c.Id, d => (string) d[keycolumns.Value]);
        }

        /// <summary>
        ///     Retrieves the multiple.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="fetchXml">The fetch XML.</param>
        /// <returns>Dictionary&lt;Guid, Entity&gt;.</returns>
        public static Dictionary<Guid, Entity> RetrieveMultiple(IOrganizationService crmService, string fetchXml)
        {
            var fetchToQueryRequest = new FetchXmlToQueryExpressionRequest
            {
                FetchXml = fetchXml
            };

            var response = crmService.Execute(fetchToQueryRequest) as FetchXmlToQueryExpressionResponse;
            return response == null ? null : RetrieveMultiple(crmService, response.Query);
        }

        /// <summary>
        ///     Retrieves the multiple.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityName">Name of the entity.</param>
        /// <param name="conditions">The conditions.</param>
        /// <returns>IEnumerable&lt;Entity&gt;.</returns>
        public static IEnumerable<Entity> RetrieveMultiple(IOrganizationService crmService,
            string entityName,
            params ConditionExpression[] conditions)
        {
            var query = new QueryExpression(entityName)
            {
                ColumnSet = new ColumnSet(XrmMetadataHelperFunctions.GetNonSystemColumns(
                    crmService, entityName, DiffXrmXml.Exceptions))
            };

            query.Criteria.Conditions.AddRange(conditions);
            return RetrieveMultiple(crmService, query).Select(c => c.Value);
        }

        /// <summary>
        ///     Retrieves the multiple.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="query">The query.</param>
        /// <returns>Dictionary&lt;Guid, Entity&gt;.</returns>
        public static Dictionary<Guid, Entity> RetrieveMultiple(IOrganizationService crmService, QueryExpression query)
        {
            var collection = new EntityCollection();

            query.PageInfo = query.PageInfo ?? new PagingInfo();
            query.PageInfo.Count = 5000;
            query.PageInfo.PageNumber = 1;

            var response = crmService.RetrieveMultiple(query);

            collection.Entities.AddRange(response.Entities);

            while (response.MoreRecords)
            {
                query.PageInfo = query.PageInfo ?? new PagingInfo();
                query.PageInfo.Count = 5000;
                query.PageInfo.PageNumber++;
                query.PageInfo.PagingCookie = response.PagingCookie;
                response = crmService.RetrieveMultiple(query);
                collection.Entities.AddRange(response.Entities);
            }

            var list = collection.Entities.ToDictionary(c => c.Id);
            return list;
        }

        /// <summary>
        ///     Retrieves the name of the multiple by entity.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="entityName">Name of the entity.</param>
        /// <param name="allColumns">if set to <c>true</c> [all columns].</param>
        /// <param name="columns">The columns.</param>
        /// <returns>Dictionary&lt;Guid, Entity&gt;.</returns>
        public static Dictionary<Guid, Entity> RetrieveMultipleByEntityName(IOrganizationService crmService,
            string entityName,
            bool allColumns = false,
            params string[] columns)
        {
            var keycolumns = XrmMetadataHelperFunctions.GetEntityPrimaryColumns(crmService, entityName);

            var criteria = new FilterExpression();

            if (string.CompareOrdinal(entityName, EntityName.connection) == 0)
            {
                criteria.AddCondition(systementity.ismaster, ConditionOperator.Equal, true);
            }

            return RetrieveMultiple(crmService,
                new QueryExpression(entityName)
                {
                    ColumnSet = columns.Length == 0
                        ? ((!allColumns && !string.IsNullOrEmpty(keycolumns.Value))
                            ? new ColumnSet(keycolumns.Key, keycolumns.Value, systementity.createdon,
                                systementity.createdby)
                            : new ColumnSet(XrmMetadataHelperFunctions.GetNonSystemColumns(crmService, entityName,
                                DiffXrmXml.Exceptions)))
                        : new ColumnSet(columns),
                    Distinct = true,
                    Criteria = criteria
                }
                );
        }

        /// <summary>
        ///     Assigns the record.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="entityName">Name of the entity.</param>
        /// <param name="id">The identifier.</param>
        public static void TryAssignRecord(IOrganizationService crmService, EntityReference owner, string entityName,
            Guid id)
        {
            try
            {
                "setting ownership for record with id {0}".Trace(id);

                var assignRequest = new AssignRequest
                {
                    Assignee = owner,
                    Target = new EntityReference(entityName, id)
                };

                crmService.Execute(assignRequest);
                "ownership of the record with {0} successfully assigned.".Trace(id);
            }
            catch (FaultException<OrganizationServiceFault> orgFaultException)
            {
                orgFaultException.Message.TraceError(orgFaultException);
            }
        }

        /// <summary>
        ///     Updates the solution version number.
        /// </summary>
        /// <param name="crmService">The CRM service.</param>
        /// <param name="uniqueName">Name of the unique.</param>
        /// <param name="versionNumber">The version number.</param>
        /// <param name="description">The description.</param>
        public static void UpdateSolutionVersionNumber(IOrganizationService crmService, string uniqueName,
            double versionNumber, string description)
        {
            var query = new QueryExpression(EntityName.solution) {ColumnSet = new ColumnSet(true)};
            query.Criteria.AddCondition(solution.uniquename, ConditionOperator.Equal, uniqueName);

            var solutions = crmService.RetrieveMultiple(query);

            if (solutions.Entities.Count == 0) return;

            var solutionRecord = solutions.Entities.FirstOrDefault();

            solutionRecord[solution.version] = versionNumber + ".0";
            solutionRecord[solution.description] = description;
            crmService.Update(solutionRecord);
        }
    }
}