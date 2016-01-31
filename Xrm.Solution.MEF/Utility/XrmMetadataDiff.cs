// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-05-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Xrm.Solution.MEF;
using Xrm.Solution.Configuration;
using Xrm.Solution.Common;

namespace Xrm.Solution.Utility
{
    /// <summary>
    ///     Class XrmMetadataDiff.
    /// </summary>
    public static class XrmMetadataDiff
    {
        /// <summary>
        ///     Adds the components to solution.
        /// </summary>
        /// <param name="sourceService">The source service.</param>
        /// <param name="destinationService">The destination service.</param>
        /// <param name="entityName">Name of the entity.</param>
        /// <param name="solutionComponentType">Type of the solution component.</param>
        /// <param name="componentType">Type of the component.</param>
        /// <param name="destinationDataSourceElement">The destination data source element.</param>
        /// <param name="context">The xrm activity context</param>
        /// <param name="noOfThreads">The no of threads.</param>
        /// <param name="checkManaged">
        ///     if set to <c>true</c> [check if component is managed and exclude from adding to the
        ///     solution].
        /// </param>
        public static void AddComponentsToSolution(string entityName,
            SolutionPackageType solutionComponentType,
            ComponentType componentType,
            XrmActivityContext context,
            bool checkManaged = true)
        {
            var columns = XrmMetadataHelperFunctions.GetNonSystemColumns(context.Source, entityName);

            var sourceEntities = XrmHelperFunctions.RetrieveMultipleByEntityName(
                context.Source, 
                entityName, 
                true,
                columns);

            var destinationEntities = XrmHelperFunctions.RetrieveMultipleByEntityName(
                context.Destination, 
                entityName,
                true,
                columns);

            AddComponentsToSolution(
                sourceEntities,
                destinationEntities,
                solutionComponentType,
                componentType,
                context,
                checkManaged);
        }

        /// <summary>
        /// Adds the components to solution.
        /// </summary>
        /// <param name="sourceService">The source service.</param>
        /// <param name="destinationService">The destination service.</param>
        /// <param name="sourceEntities">The source entities.</param>
        /// <param name="destinationEntities">The destination entities.</param>
        /// <param name="destinationDataSourceElement">The destination data source element.</param>
        /// <param name="solutionComponentType">Type of the solution component.</param>
        /// <param name="componentType">Type of the component.</param>
        /// <param name="context">The context.</param>
        /// <param name="noOfThreads">The no of threads.</param>
        /// <param name="checkManaged">if set to <c>true</c> [check managed].</param>
        /// <param name="checkDifference">if set to <c>true</c> [check difference].</param>
        public static void AddComponentsToSolution(
            Dictionary<Guid, Entity> sourceEntities,
            Dictionary<Guid, Entity> destinationEntities,
            SolutionPackageType solutionComponentType,
            ComponentType componentType,
            XrmActivityContext context,
            bool checkManaged = true,
            bool checkDifference = true)
        {
            
            if (sourceEntities.Count == 0) return;

            var primaryAttributes = XrmMetadataHelperFunctions.GetEntityPrimaryColumns(context.Source,
                sourceEntities.FirstOrDefault().Value.LogicalName);

            XrmMetadataHelperFunctions.ProcessTask(sourceEntities,
                () => context.Source,
                (sourceEntity, sourceProxy) =>
                {
                    var description = (primaryAttributes.Value != null)
                        ?  (string) sourceEntity[primaryAttributes.Value]
                        : sourceEntity.LogicalName + "[" + sourceEntity.Id + "]";

                    if (XrmHelperFunctions.IsExcemptedFromProcessing(sourceEntity.LogicalName,
                       sourceEntity.Id,
                       context.Configuration.Exceptions)) return;

                    if (primaryAttributes.Value != null)
                        ">> {0}".TraceVerbose(description);

                    if (checkManaged &&
                        sourceEntity.Contains(systementity.ismanaged) &&
                        (bool) sourceEntity[systementity.ismanaged])
                        return;


                    var destinationEntity = destinationEntities.ContainsKey(sourceEntity.Id)
                        ? destinationEntities[sourceEntity.Id]
                        : null;


                    if (checkDifference)
                    {
                        var isDifferent =
                            XrmMetadataHelperFunctions.FindDifferenceBetweenObjects
                            (
                                sourceEntity,
                                destinationEntity, 
                                description, 
                                componentType,
                                context
                            );

                        if (!isDifferent) return;
                    }

                    XrmMetadataHelperFunctions.AddToSolutions(sourceProxy,
                        context.Configuration.Solutions,
                        componentType,
                        sourceEntity.Id);
                },
                null,
                context.Configuration.Threads);
        }
    }
}