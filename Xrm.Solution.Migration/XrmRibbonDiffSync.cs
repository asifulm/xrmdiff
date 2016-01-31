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
    /// Class XrmRibbonDiffSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Ribbon definition]")]
    public class XrmRibbonDiffSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Adds the ribbon definition to solution.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution
            (
               context,
               EntityName.ribboncustomization,
               SolutionPackageType.Entity,
               ComponentType.RibbonCustomization
            );
        }
    }
}
