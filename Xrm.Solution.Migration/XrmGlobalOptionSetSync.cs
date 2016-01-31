// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

using System.ComponentModel.Composition;
using Xrm.Solution.Common;
using Xrm.Solution.MEF;
using Xrm.Solution.Utility;

namespace Xrm.Solution.Components
{
    /// <summary>
    ///     Class XrmGlobalOptionSetSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index = 10, Description = "[Global options]")]
    public class XrmGlobalOptionSetSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        ///     Synchronizes the entities from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            var sourceOptionSetMetadataBase = XrmMetadataHelperFunctions.GetAllOptionSetMetadata(context.Source);
            var destinationOptionSetMetadataBase = XrmMetadataHelperFunctions.GetAllOptionSetMetadata(context.Destination);

            XrmMetadataHelperFunctions.ProcessTask
            (
                sourceOptionSetMetadataBase,
                 () =>
                 {
                     return new[] { context.Source, context.Destination };
                 },
                (sourceOptionSet, proxyCollection) =>
                {
                    if (!sourceOptionSet.IsCustomizable.Value) return;

                    if (sourceOptionSet.MetadataId != null &&
                        XrmHelperFunctions.IsExcemptedFromProcessing(sourceOptionSet.Name,
                            sourceOptionSet.MetadataId.Value,
                            context.Configuration.Exceptions))
                        return;

                    "cheking {0}".TraceVerbose(sourceOptionSet.Name);

                    if (sourceOptionSet.IsManaged != null && sourceOptionSet.IsManaged.Value) return;


                    var destinationOptionSet = destinationOptionSetMetadataBase.ContainsKey(sourceOptionSet.Name)
                        ? destinationOptionSetMetadataBase[sourceOptionSet.Name]
                        : null;

                    var isDifferent =
                        XrmMetadataHelperFunctions.FindDifferenceBetweenObjects
                        (
                            sourceOptionSet,
                            destinationOptionSet,
                            sourceOptionSet.Name,
                            ComponentType.OptionSet,
                            context
                        );


                    if (!isDifferent) return;

                    if (sourceOptionSet.MetadataId != null)
                    {
                        XrmMetadataHelperFunctions.AddToSolutions
                        (
                            proxyCollection[0],
                            context.Configuration.Solutions,
                            ComponentType.OptionSet,
                            sourceOptionSet.MetadataId.Value
                        );
                    }
                },
                null,
                context.Configuration.Threads);
        }
    }
}