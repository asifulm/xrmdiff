// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

using System.ComponentModel.Composition;
using Xrm.Solution.MEF;
using Xrm.Solution.Utility;

namespace Xrm.Solution.Components
{
    /// <summary>
    ///     Class XrmSecurityRoleSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Dashboards]")]
    public class XrmDashboardSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        ///     Synchronizes the security roles from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
       
        public override void ExecuteProcess(XrmActivityContext context)
        {
            var sourceDashboards = XrmMetadataHelperFunctions.GetDashboards(context.Source);
            var destinationDashboards = XrmMetadataHelperFunctions.GetDashboards(context.Destination);
           
            AddComponentsToSolution(context,
                sourceDashboards,
                destinationDashboards,
                SolutionPackageType.Entity,
                ComponentType.SystemForm);
        }
    }
}