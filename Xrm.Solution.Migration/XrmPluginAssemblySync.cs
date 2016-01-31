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
    using Utility;
    using MEF;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Class XrmPluginAssemblySync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Plugins]")]
    public class XrmPluginAssemblySync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {

        /// <summary>
        /// Synchronizes the plugins from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
      
        public override void ExecuteProcess(XrmActivityContext context)
        {
           AddComponentsToSolution(
             context,
             EntityName.pluginassembly, 
             SolutionPackageType.Plugins, 
             ComponentType.PluginAssembly
            );
        }
    }
}
