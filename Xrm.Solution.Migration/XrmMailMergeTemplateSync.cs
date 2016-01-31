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
    /// Class XrmMailMergeTemplateSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Mail merge]")]
    public class XrmMailMergeTemplateSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {

        /// <summary>
        /// Synchronizes the mail merge templates from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution
            (
                context,
                EntityName.mailmergetemplate,
                SolutionPackageType.Entity,
                ComponentType.MailMergeTemplate
            );
        }
    }
}
