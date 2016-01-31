// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using Xrm.Solution.Configuration;
using Xrm.Solution.Utility;

namespace Xrm.Solution.MEF
{
    /// <summary>
    ///     Class XrmActivityContext.
    /// </summary>
    public class XrmActivityContext
    {
        /// <summary>
        ///     Gets or sets the crm organization url and connection information
        /// </summary>
        /// <value>The organization url.</value>
        public XrmConfiguration Configuration { get; set; }

        /// <summary>
        ///     Source CRM Organization Service
        /// </summary>
        /// <value>The XRM services.</value>
        public IOrganizationService Source { get; set; }

        /// <summary>
        ///     Destination CRM Organization Service
        /// </summary>
        /// <value>The XRM services.</value>
        public IOrganizationService Destination { get; set; }

        /// <summary>
        /// Gets or sets the change list.
        /// </summary>
        /// <value>The change list.</value>
        public Dictionary<KeyValuePair<string, ComponentType>, List<DiffItem>> ChangeList { get; set; }


        /// <summary>
        /// Gets or sets the process executed count.
        /// </summary>
        /// <value>The process executed count.</value>
        public int Depth { get; set; }

        public XrmActivityContext()
        {
            ChangeList = new Dictionary<KeyValuePair<string, ComponentType>, List<DiffItem>>();
        }
       
    }
}