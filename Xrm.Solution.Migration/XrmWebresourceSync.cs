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
    using MEF;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Class XrmWebresourceSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =10, Description="[Web resources]")]
    public class XrmWebresourceSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Synchronizes the webresources from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution
            (
                 context,
                 EntityName.webresource,
                 SolutionPackageType.Webresources,
                 ComponentType.WebResource
            );
        }
    }
}