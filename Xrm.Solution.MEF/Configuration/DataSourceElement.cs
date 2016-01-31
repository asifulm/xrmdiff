// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Created          : 05-16-2015
//
// Last Modified By : asifulm
// Last Modified On : 05-16-2015
// ***********************************************************************

using System.Configuration;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class DataSourceElement.
    /// </summary>
    public class DataSourceElement : ConfigurationElement
    {
        /// <summary>
        ///     Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        [ConfigurationProperty("domain")]
        public string Domain
        {
            get { return (string) base["domain"]; }
            set { base["domain"] = value; }
        }

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
        ///     Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [ConfigurationProperty("password")]
        public string Password
        {
            get { return (string) base["password"]; }
            set { base["password"] = value; }
        }

        /// <summary>
        ///     Gets or sets the organization's unique name.
        /// </summary>
        /// <value>The organization unique name.</value>
        [ConfigurationProperty("uniquename")]
        public string UniqueName
        {
            get { return (string) base["uniquename"]; }
            set { base["uniquename"] = value; }
        }

        /// <summary>
        ///     Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [ConfigurationProperty("url")]
        public string Url
        {
            get { return (string) base["url"]; }
            set { base["url"] = value; }
        }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [ConfigurationProperty("username")]
        public string UserName
        {
            get { return (string) base["username"]; }
            set { base["username"] = value; }
        }
    }

    /// <summary>
    ///     Class DataSourceElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (DataSourceElement))]
    public class DataSourceElementCollection : ConfigurationElementCollectionBase<DataSourceElement>
    {
        /// <summary>
        ///     The property
        /// </summary>
        private const string Property = "datasource";

        /// <summary>
        ///     The property name
        /// </summary>
        /// <value>The name of the property.</value>
        public override string PropertyName
        {
            get { return Property; }
        }

        /// <summary>
        ///     Adds the items.
        /// </summary>
        /// <param name="dataSourceElements">The data source elements.</param>
        public void AddItems(params DataSourceElement[] dataSourceElements)
        {
            foreach (var dataSource in dataSourceElements)
            {
                BaseAdd(dataSource);
            }
        }
    }
}