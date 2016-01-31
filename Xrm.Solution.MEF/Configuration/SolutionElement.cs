// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-27-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-27-2015
// ***********************************************************************

using System.Configuration;
using Xrm.Solution.MEF;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class SolutionElement.
    /// </summary>
    public class SolutionElement : ConfigurationElement
    {
        /// <summary>
        ///     Gets or sets the default name of the publisher unique.
        /// </summary>
        /// <value>The default name of the publisher unique.</value>
        [ConfigurationProperty("defaultPublisherUniqueName")]
        [DefaultSettingValue(ParameterName.DefaultPublisherId)]
        public string DefaultPublisherUniqueName
        {
            get { return (string) base["defaultPublisherUniqueName"]; }
            set { base["defaultPublisherUniqueName"] = value; }
        }

        /// <summary>
        ///     Gets or sets the export directory.
        /// </summary>
        /// <value>The reporting directory.</value>
        [ConfigurationProperty("exportDirectory")]
        [DefaultSettingValue(@"C:\Xrm\")]
        public string ExportDirectory
        {
            get { return (string) base["exportDirectory"]; }
            set { base["exportDirectory"] = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is managed.
        /// </summary>
        /// <value><c>true</c> if this instance is managed; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("ismanaged")]
        [DefaultSettingValue("false")]
        public bool IsManaged
        {
            get { return (bool) base["ismanaged"]; }
            set { base["ismanaged"] = value; }
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
        ///     Gets or sets a value indicating whether this <see cref="SolutionElement" /> is publish.
        /// </summary>
        /// <value><c>true</c> if publish; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("import")]
        [DefaultSettingValue("false")]
        public bool Publish
        {
            get { return (bool) base["import"]; }
            set { base["import"] = value; }
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [ConfigurationProperty("version")]
        [DefaultSettingValue("1.0.1")]
        public string Version
        {
            get { return (string) base["version"]; }
            set { base["version"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to include entities as part of the solution download.
        /// </summary>
        [ConfigurationProperty("exportEntities")]
        [DefaultSettingValue("true")]
        public bool ExportEntities
        {
            get { return (bool) base["exportEntities"]; }
            set { base["exportEntities"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to include plugins as part of the solution download.
        /// </summary>
        [ConfigurationProperty("exportPlugins")]
        [DefaultSettingValue("true")]
        public bool ExportPlugins
        {
            get { return (bool) base["exportPlugins"]; }
            set { base["exportPlugins"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to include workflows as part of the solution download.
        /// </summary>
        [ConfigurationProperty("exportWorkflows")]
        [DefaultSettingValue("true")]
        public bool ExportWorkflows
        {
            get { return (bool) base["exportWorkflows"]; }
            set { base["exportWorkflows"] = value; }
        }


        /// <summary>
        ///     Gets or sets whether to include reports as part of the solution download.
        /// </summary>
        [ConfigurationProperty("exportReports")]
        [DefaultSettingValue("true")]
        public bool ExportReports
        {
            get { return (bool) base["exportReports"]; }
            set { base["exportReports"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to include webresources as part of the solution download.
        /// </summary>
        [ConfigurationProperty("exportWebresources")]
        [DefaultSettingValue("true")]
        public bool ExportWebresources
        {
            get { return (bool) base["exportWebresources"]; }
            set { base["exportWebresources"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to include securityroles as part of the solution download.
        /// </summary>
        [ConfigurationProperty("exportSecurityRoles")]
        [DefaultSettingValue("true")]
        public bool ExportSecurityRoles
        {
            get { return (bool) base["exportSecurityRoles"]; }
            set { base["exportSecurityRoles"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to include securityroles as part of the solution download.
        /// </summary>
        [ConfigurationProperty("enabled")]
        [DefaultSettingValue("true")]
        public bool IsEnabled
        {
            get { return (bool)base["enabled"]; }
            set { base["enabled"] = value; }
        }
    }

    /// <summary>
    ///     Class SolutionElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (SolutionElement))]
    public class SolutionElementCollection : ConfigurationElementCollectionBase<SolutionElement>
    {
        /// <summary>
        ///     The property name
        /// </summary>
        /// <value>The name of the property.</value>
        public override string PropertyName => "solution";

        /// <summary>
        ///     Adds the items.
        /// </summary>
        /// <param name="solutionElements">The solution elements.</param>
        public void AddItems(params SolutionElement[] solutionElements)
        {
            foreach (var solution in solutionElements)
            {
                BaseAdd(solution);
            }
        }
    }
}