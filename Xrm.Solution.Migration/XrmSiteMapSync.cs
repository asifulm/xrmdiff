// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-19-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-19-2015
// ***********************************************************************

using System.ComponentModel.Composition;
using Xrm.Solution.MEF;

namespace Xrm.Solution.Components
{
    /// <summary>
    /// Class XrmSiteMapSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Site Map]")]
    public class XrmSiteMapSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Adds the site map to solution.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution
            (  
                context,
               EntityName.sitemap,
               SolutionPackageType.Entity,
               ComponentType.SiteMap
            );

        }
    }
}
