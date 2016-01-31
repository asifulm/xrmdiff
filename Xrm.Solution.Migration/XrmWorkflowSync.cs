// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-11-2015
// ***********************************************************************

using System.ComponentModel.Composition;
using Xrm.Solution.MEF;

namespace Xrm.Solution.Components
{
    /// <summary>
    /// Class XrmWorkflowSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Workflow]")]
    public class XrmWorkflowSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Synchronizes the workflows from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution
            (
                context,
                EntityName.workflow,
                SolutionPackageType.Entity,
                ComponentType.Workflow
            );
        }
    }
}
