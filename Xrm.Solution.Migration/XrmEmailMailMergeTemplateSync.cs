// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-11-2015
// ***********************************************************************

namespace Xrm.Solution.Components
{
    using Utility;
    using MEF;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Class XrmEmailMailMergeTemplateSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Email Templates]")]
    public class XrmEmailMailMergeTemplateSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {

        /// <summary>
        /// Synchronizes the email templates from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution(context, 
              EntityName.template,
              SolutionPackageType.Entity, 
              ComponentType.EmailTemplate);
        }
    }
}
