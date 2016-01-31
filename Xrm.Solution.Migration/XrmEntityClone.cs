// ***********************************************************************
// Assembly         : Xrm.Solution.Migration
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

using System.Linq;
using Activity.Framework.Common;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Xrm.Utility;

namespace Xrm.Solution.Migration
{
    /// <summary>
    ///     Class XrmEntitySync.
    /// </summary>
    public class XrmEntityClone : XrmSolutionMigrationBase
    {
        /// <summary>
        ///     Synchronizes the entities from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        [XrmActivity(Description = "[Entities] >>>")]
        public void ExtractEntities(XrmActivityContext context)
        {
            var destinationService = context.XrmServices[Destination];
            var sourceService = context.XrmServices[Source];

            var sourceEntitities = XrmMetadataHelperFunctions.GetAllEntityMetadataDictionary(sourceService,
                EntityFilters.Attributes);
            var destinationEntities = XrmMetadataHelperFunctions.GetAllEntityMetadataDictionary(destinationService,
                EntityFilters.Attributes);

            XrmMetadataHelperFunctions.ProcessTask(sourceEntitities,
                () => new XrmConnectionManager().GetConnection(context.Configuration.DataSources[Destination]),
                sourceEntity =>
                {
                    if (sourceEntity.IsCustomEntity != null && !sourceEntity.IsCustomEntity.Value) return;
                    if (sourceEntity.IsIntersect != null && sourceEntity.IsIntersect.Value) return;
                    if (sourceEntity.MetadataId != null &&
                        XrmHelperFunctions.IsExcemptedFromProcessing(sourceEntity.LogicalName,
                            sourceEntity.MetadataId.Value,
                            context.Configuration.Exceptions)) return;

                    "create entity {0}".Trace(sourceEntity.LogicalName);

                    var destinationEntity = destinationEntities.ContainsKey(sourceEntity.LogicalName)
                        ? destinationEntities[sourceEntity.LogicalName]
                        : null;


                    if (destinationEntity != null) return;
                    var request = new CreateEntityRequest()
                    {
                        Entity = sourceEntity,
                        PrimaryAttribute = (StringAttributeMetadata)  sourceEntity.Attributes.FirstOrDefault(c => c.IsPrimaryName != null && c.IsPrimaryName.Value)
                    };

                    destinationService.Execute(request);
                },
                null,
                context.Configuration.Threads);
        }
    }
}