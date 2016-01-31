// Configure log4net using the .config file

using System;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Reflection;
using Xrm.Solution.Configuration;
using Xrm.Solution.Log;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
// This will cause log4net to look for a configuration file
// called ConsoleApp.exe.config in the application base
// directory (i.e. the directory containing ConsoleApp.exe)

namespace XrmDiffUtility
{
    class Program
    {
        /// <summary>
        /// The XRM configuration node
        /// </summary>
        public const string XrmConfigurationNode = "xrmConfiguration";

        // Create a logger for use in this class
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger("XrmDiffUtility");
        // NOTE that using System.Reflection.MethodBase.GetCurrentMethod().DeclaringType
        // is equivalent to typeof(LoggingExample) but is more portable
        // i.e. you can copy the code directly into another class without
        // needing to edit the code.

        static void Main()
        {
            Logger.Instance.Information = message =>
            {
                Log.Info(message);
                return true;
            };

            Logger.Instance.Verbose = message =>
            {
                Log.Debug(message);
                return true;
            };

            Logger.Instance.Success = Logger.Instance.Information;
            Logger.Instance.Warning = Logger.Instance.Information;

            Logger.Instance.Error = (message, exception) =>
            {
                Log.Error(message, exception);
                return true;
            };

            var aggregateCatalog = new AggregateCatalog(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()), 
                new DirectoryCatalog(".\\"));
            
            CompositionContainer containter = new CompositionContainer(aggregateCatalog);

            var solutionComponents = containter.GetExportedValue<SolutionDiffComponents>();
            //containter.ComposeParts(solutionComponents);

            var configuration = ConfigurationManager.GetSection("xrmConfiguration") as XrmConfiguration;
            if (!solutionComponents.Execute(configuration))
                Console.ReadKey();
        }
    }
}
