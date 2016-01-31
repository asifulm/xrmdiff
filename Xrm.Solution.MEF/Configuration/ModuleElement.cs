// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Created          : 05-16-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-02-2015
// ***********************************************************************

using System.Configuration;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class DataSourceElement.
    /// </summary>
    public class ModuleElement : ConfigurationElement
    {
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return (string) base["name"]; }
            set { base["name"] = value; }
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [ConfigurationProperty("type")]
        public string Type
        {
            get { return (string) base["type"]; }
            set { base["type"] = value; }
        }
    }

    /// <summary>
    ///     Class DataSourceElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (ModuleElement))]
    public class ModuleElementCollection : ConfigurationElementCollectionBase<ModuleElement>
    {
        internal const string Property = "module";

        public override string PropertyName
        {
            get { return Property; }
        }
    }
}