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
    /// Class ExceptionElement.
    /// </summary>
    public class ExceptionElement : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the name of the logical.
        /// </summary>
        /// <value>The name of the logical.</value>
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        /// <summary>
        /// Gets or sets the metadata identifier.
        /// </summary>
        /// <value>The metadata identifier.</value>
        [ConfigurationProperty("metadataId")]
        public string MetadataId
        {
            get { return (string)base["metadataId"]; }
            set { base["metadataId"] = value; }
        }
    }

    /// <summary>
    /// Class ExceptionElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (ExceptionElement))]
    public class ExceptionElementCollection : ConfigurationElementCollectionBase<ExceptionElement>
    {
        /// <summary>
        /// The property
        /// </summary>
        private const string Property = "exception";

        /// <summary>
        /// The property name
        /// </summary>
        /// <value>The name of the property.</value>
        public override string PropertyName
        {
            get { return Property; }
        }
    }
}