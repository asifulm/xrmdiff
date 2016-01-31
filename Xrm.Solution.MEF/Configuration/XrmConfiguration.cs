// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 05-16-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-12-2015
// ***********************************************************************

using System;
using System.Configuration;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class XrmConfiguration.
    /// </summary>
    public class XrmConfiguration : ConfigurationSection
    {
        /// <summary>
        ///     Gets or sets the data sources.
        /// </summary>
        /// <value>The data sources.</value>
        [ConfigurationProperty("datasources")]
        public DataSourceElementCollection DataSources
        {
            get { return (DataSourceElementCollection) base["datasources"]; }
            set { base["datasources"] = value; }
        }

        /// <summary>
        ///     Gets or sets the drop location.
        /// </summary>
        /// <value>The drop location.</value>
        [ConfigurationProperty("artifactsDropLocation")]
        public string DropLocation
        {
            get { return (string) base["artifactsDropLocation"]; }
            set { base["artifactsDropLocation"] = value; }
        }

        /// <summary>
        ///     Gets or sets the exceptions.
        /// </summary>
        /// <value>The exceptions.</value>
        [ConfigurationProperty("exceptions")]
        public ExceptionElementCollection Exceptions
        {
            get { return (ExceptionElementCollection) base["exceptions"]; }
            set { base["exceptions"] = value; }
        }

        /// <summary>
        ///     Gets or sets the migration elements
        /// </summary>
        /// <value>The migration.</value>
        [ConfigurationProperty("migrations")]
        public MigrationElementCollection Migration
        {
            get { return (MigrationElementCollection) base["migrations"]; }
            set { base["migrations"] = value; }
        }

        /// <summary>
        ///     Gets or sets the modules to load.
        /// </summary>
        /// <value>The modules.</value>
        [ConfigurationProperty("modules")]
        public ModuleElementCollection Modules
        {
            get { return (ModuleElementCollection) base["modules"]; }
            set { base["modules"] = value; }
        }

        /// <summary>
        ///     Gets or sets the pre import solutions.
        /// </summary>
        /// <value>The pre import solutions.</value>
        [ConfigurationProperty("preImportSolutions")]
        public PreImportSolutionElementCollection PreImportSolutions
        {
            get { return (PreImportSolutionElementCollection) base["preImportSolutions"]; }
            set { base["preImportSolutions"] = value; }
        }

        /// <summary>
        ///     Gets or sets the export directory.
        /// </summary>
        /// <value>The reporting directory.</value>
        [ConfigurationProperty("reportDirectory")]
        [DefaultSettingValue(@"C:\Xrm\")]
        public string ReportDirectory
        {
            get { return (string) base["reportDirectory"]; }
            set { base["reportDirectory"] = value; }
        }

        /// <summary>
        ///     Gets or sets the drop location.
        /// </summary>
        /// <value>The drop location.</value>
        [ConfigurationProperty("solutionPrefix")]
        public string SolutionPrefix
        {
            get { return (string) base["solutionPrefix"]; }
            set { base["solutionPrefix"] = value; }
        }

        /// <summary>
        ///     Gets or sets the solution elements
        /// </summary>
        /// <value>The migration.</value>
        [ConfigurationProperty("solutions")]
        public SolutionElementCollection Solutions
        {
            get { return (SolutionElementCollection)base["solutions"]; }
            set { base["solutions"] = value; }
        }

        /// <summary>
        ///     Gets or sets whether to export reports...
        /// </summary>
        /// <value>Thread Count</value>
        [ConfigurationProperty("exportReports")]
        [DefaultSettingValue("true")]
        public bool ExportReports
        {
            get { return Convert.ToBoolean(base["exportReports"]); }
            set { base["exportReports"] = value.ToString(); }
        }


        /// <summary>
        ///     Gets or sets the no. of threads.
        /// </summary>
        /// <value>Thread Count</value>
        [ConfigurationProperty("noOfThreads")]
        public int Threads
        {
            get { return Convert.ToInt32(base["noOfThreads"]); }
            set { base["noOfThreads"] = value.ToString(); }
        }
    }
}