// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

namespace Xrm.Solution.Components
{
    using System.Linq;
    using Utility;
    using MEF;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Class XrmPluginStepsSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Plugin steps]")]
    public class XrmPluginStepsSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {

        /// <summary>
        /// Synchronizes the plugin steps from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            var sourcePlugins = XrmHelperFunctions.GetPluginsSteps(context.Source).Entities.ToDictionary(c => c.Id);
            var destinationPlugins = XrmHelperFunctions.GetPluginsSteps(context.Destination).Entities.ToDictionary(c => c.Id);

            AddComponentsToSolution
            (
                context,
                sourcePlugins, 
                destinationPlugins,
                SolutionPackageType.Plugins, 
                ComponentType.SdkMessageProcessingStep
            );
        }
    }
}
