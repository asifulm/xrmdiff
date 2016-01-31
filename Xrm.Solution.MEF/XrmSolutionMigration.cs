using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Xrm.Solution.Utility;

namespace Xrm.Solution.MEF
{
    [InheritedExport(typeof(IXrmXrmDiffUtility))]
    public abstract class XrmXrmDiffUtility : IXrmXrmDiffUtility
    {
        public const string Source = "source";
        public const string Destination = "destination";

        public void AddComponentsToSolution(XrmActivityContext context, string entityName,
            SolutionPackageType packageType,
            ComponentType componentType)
        {
            XrmMetadataDiff.AddComponentsToSolution(
                EntityName.kbarticletemplate,
                SolutionPackageType.Entity,
                ComponentType.KbArticleTemplate,
                context);
        }

        public void AddComponentsToSolution(XrmActivityContext context,
                Dictionary<Guid ,Entity> sourceItems,
                Dictionary<Guid, Entity> destinationItems,
                SolutionPackageType solutionPackageType,
                ComponentType componentType)
        {

            XrmMetadataDiff.AddComponentsToSolution(
               sourceItems,
               destinationItems,
               SolutionPackageType.Entity,
               ComponentType.SystemForm,
               context);
        }

        public abstract void ExecuteProcess(XrmActivityContext context);
    }
}
