// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using System.ComponentModel.Composition;
using Xrm.Solution.MEF;

namespace Xrm.Solution.Components
{
    /// <summary>
    ///     Class XrmContractTemplateSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Contract templates]")]
    public class XrmContractTemplateSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        ///     Synchronizes the contract templates from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>]
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution(context,
                EntityName.contracttemplate,
                SolutionPackageType.Entity,
                ComponentType.ContractTemplate);
        }
    }
}