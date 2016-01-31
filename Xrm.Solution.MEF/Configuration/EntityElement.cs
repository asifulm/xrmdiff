// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

using System.Configuration;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class EntityElement.
    /// </summary>
    public class EntityElement : ConfigurationElement
    {
        /// <summary>
        ///     Gets or sets the destination entity.
        /// </summary>
        /// <value>The destination entity.</value>
        [ConfigurationProperty("destination")]
        public string DestinationEntity
        {
            get { return (string) base["destination"]; }
            set { base["destination"] = value; }
        }

        /// <summary>
        ///     Gets or sets the destination URL.
        /// </summary>
        /// <value>The destination URL.</value>
        [ConfigurationProperty("destinationUrl")]
        public string DestinationUrl
        {
            get { return (string) base["destinationUrl"]; }
            set { base["destinationUrl"] = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is create.
        /// </summary>
        /// <value><c>true</c> if this instance is create; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("create")]
        public bool IsCreate
        {
            get { return (bool) base["create"]; }
            set { base["create"] = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is set owner.
        /// </summary>
        /// <value><c>true</c> if this instance is set owner; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("setOwner")]
        public bool IsSetOwner
        {
            get { return (bool) base["setOwner"]; }
            set { base["setOwner"] = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is set state.
        /// </summary>
        /// <value><c>true</c> if this instance is set state; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("setState")]
        public bool IsSetState
        {
            get { return (bool) base["setState"]; }
            set { base["setState"] = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is update.
        /// </summary>
        /// <value><c>true</c> if this instance is update; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("update")]
        public bool IsUpdate
        {
            get { return (bool) base["update"]; }
            set { base["update"] = value; }
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
        ///     Gets or sets the source URL.
        /// </summary>
        /// <value>The source URL.</value>
        [ConfigurationProperty("sourceUrl")]
        public string SourceUrl
        {
            get { return (string) base["sourceUrl"]; }
            set { base["sourceUrl"] = value; }
        }
    }

    /// <summary>
    ///     Class DataSourceElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (EntityElement))]
    public class EntityElementCollection : ConfigurationElementCollectionBase<EntityElement>
    {
        /// <summary>
        ///     The property name
        /// </summary>
        internal const string Property = "entity";

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