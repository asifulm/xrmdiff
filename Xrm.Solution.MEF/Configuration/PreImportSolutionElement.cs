// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-28-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-28-2015
// ***********************************************************************

using System.Configuration;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class PreImportSolutionElement.
    /// </summary>
    public class PreImportSolutionElement : ConfigurationElement
    {
        /// <summary>
        ///     Gets or sets the name of the logical.
        /// </summary>
        /// <value>The name of the logical.</value>
        [ConfigurationProperty("filename")]
        public string Path
        {
            get { return (string) base["filename"]; }
            set { base["filename"] = value; }
        }

        /// <summary>
        ///     Gets or sets the name of the solution.
        /// </summary>
        /// <value>The name of the solution.</value>
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return (string) base["name"]; }
            set { base["name"] = value; }
        }
    }

    /// <summary>
    ///     Class PreImportSolutionElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (PreImportSolutionElement))]
    public class PreImportSolutionElementCollection : ConfigurationElementCollectionBase<PreImportSolutionElement>
    {
        /// <summary>
        ///     The property
        /// </summary>
        private const string Property = "solution";

        /// <summary>
        ///     The property name
        /// </summary>
        /// <value>The name of the property.</value>
        public override string PropertyName
        {
            get { return Property; }
        }
    }
}