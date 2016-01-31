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
    ///     Class XrmFieldSecurityRoleSync.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="[Field security roles]")]
    public class XrmFieldSecurityRoleSync : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        ///     Synchronizes the field security roles from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            AddComponentsToSolution
            (
                context,
                EntityName.fieldsecurityprofile, 
                SolutionPackageType.SecurityRoles, 
                ComponentType.FieldSecurityProfile
            );
        }
    }
}