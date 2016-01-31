// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-28-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-28-2015
// ***********************************************************************

using System;
using System.ComponentModel.Composition;
using Xrm.Solution.MEF;
using Xrm.Solution.Utility;

namespace Xrm.Solution.Components
{
    /// <summary>
    /// Class XrmCleanUpSolutions.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =0, Description="[Pre-cleanup]")]
    public class XrmCleanUpSolutions : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Executes the process.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            XrmMetadataHelperFunctions.AddToSolutions(
                context.Source,
                context.Configuration.Solutions,
                ComponentType.DisplayString, 
                Guid.Empty, true);
        }
    }
}