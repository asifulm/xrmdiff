// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

using Microsoft.Xrm.Sdk.Metadata;
using System.ComponentModel.Composition;
using Xrm.Solution.Common;
using Xrm.Solution.MEF;
using Xrm.Solution.Utility;

namespace Xrm.Solution.Components
{
    /// <summary>
    ///     Class XrmEntitySync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =10, Description="[Entities]")]
    public class XrmEntitySync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        ///     Synchronizes the entities from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>

        public override void ExecuteProcess(XrmActivityContext context)
        {

            "loading metadata from source.".Trace();
            var sourceEntitities = XrmMetadataHelperFunctions.GetAllEntityMetadataDictionary(context.Source,
                EntityFilters.All);

            "loading metadata from destination.".Trace();
            var destinationEntities = XrmMetadataHelperFunctions.GetAllEntityMetadataDictionary(context.Destination,
                EntityFilters.All);

            XrmMetadataHelperFunctions.ProcessTask(sourceEntitities,
                () => new[] { context.Source, context.Destination },
                (sourceEntity, proxyCollection) =>
                {
                    if (!sourceEntity.IsCustomizable.Value) return;
                    if (sourceEntity.IsImportable != null && !sourceEntity.IsImportable.Value) return;

                    if (sourceEntity.MetadataId != null &&
                        XrmHelperFunctions.IsExcemptedFromProcessing(sourceEntity.LogicalName,
                            sourceEntity.MetadataId.Value,
                            context.Configuration.Exceptions))
                        return;

                    "cheking {0}".TraceVerbose(sourceEntity.LogicalName);

                    var destinationEntity = destinationEntities.ContainsKey(sourceEntity.LogicalName)
                        ? destinationEntities[sourceEntity.LogicalName]
                        : null;

                    var isDifferent =
                        XrmMetadataHelperFunctions.FindDifferenceBetweenObjects
                        (
                            sourceEntity,
                            destinationEntity,
                            sourceEntity.LogicalName,
                            ComponentType.Entity,
                            context
                        );

                    if (!isDifferent)
                    {
                        isDifferent |= XrmMetadataHelperFunctions.FindDifferenceBetweenObjects(
                            XrmMetadataHelperFunctions.GetSystemForm(proxyCollection[0], sourceEntity),
                            XrmMetadataHelperFunctions.GetSystemForm(proxyCollection[1], destinationEntity),
                            sourceEntity.LogicalName + " - Forms",
                            ComponentType.Entity,
                            context);
                    }

                    if (!isDifferent) return;

                    if (sourceEntity.MetadataId != null)
                    {
                        XrmMetadataHelperFunctions.AddToSolutions
                        (
                            proxyCollection[0],
                            context.Configuration.Solutions,
                            ComponentType.Entity,
                            sourceEntity.MetadataId.Value
                        );
                    }
                },
                null,
                context.Configuration.Threads);
        }
    }
}