// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-04-2015
// ***********************************************************************

using System;
using System.Configuration;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class MigrationElement.
    /// </summary>
    public class MigrationElement : ConfigurationElement
    {
        /// <summary>
        ///     Gets or sets a value indicating whether [clean up records].
        /// </summary>
        /// <value><c>true</c> if [clean up records]; otherwise, <c>false</c>.</value>
        [ConfigurationProperty("processDelete")]
        public bool CleanUpRecords
        {
            get { return Convert.ToBoolean(base["processDelete"]); }
            set { base["processDelete"] = value; }
        }

        /// <summary>
        ///     Gets or sets the entities.
        /// </summary>
        /// <value>The entities.</value>
        [ConfigurationProperty("entities")]
        public EntityElementCollection Entities
        {
            get { return (EntityElementCollection) base["entities"]; }
            set { base["entities"] = value; }
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
        ///     Gets or sets the no of processing threads.
        /// </summary>
        /// <value>The no of processing threads.</value>
        [ConfigurationProperty("noOfThreads")]
        public int NoOfProcessingThreads
        {
            get { return Convert.ToInt32(base["noOfThreads"]); }
            set { base["noOfThreads"] = value; }
        }

        /// <summary>
        ///     Gets or sets the temporary role.
        /// </summary>
        /// <value>The temporary role.</value>
        [ConfigurationProperty("temporarySecurityRole")]
        public string TemporaryRole
        {
            get { return (string) base["temporarySecurityRole"]; }
            set { base["temporarySecurityRole"] = value; }
        }
    }

    /// <summary>
    ///     Class DataSourceElementCollection.
    /// </summary>
    [ConfigurationCollection(typeof (MigrationElement))]
    public class MigrationElementCollection : ConfigurationElementCollectionBase<MigrationElement>
    {
        /// <summary>
        ///     The property name
        /// </summary>
        internal const string Property = "migration";

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