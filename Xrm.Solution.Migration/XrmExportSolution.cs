// ***********************************************************************
// Assembly         : Xrm.Solution.Components
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-11-2015
// ***********************************************************************

using System;
using System.Globalization;
using System.IO;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Xrm.Solution.MEF;
using Xrm.Solution.Configuration;
using Xrm.Solution.Common;
using System.ComponentModel.Composition;
using Microsoft.Xrm.Sdk;

namespace Xrm.Solution.Components
{
    /// <summary>
    /// Class XrmExportSolution.
    /// </summary>
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =100, Description="Export and Import Solution")]
    public class XrmExportSolution : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Exports the XRM solution.
        /// </summary>
        /// <param name="context">The context.</param>
        
        public override void ExecuteProcess(XrmActivityContext context)
        {
            foreach (SolutionElement solution in context.Configuration.Solutions)
            {
                if (!solution.IsEnabled) continue;
                var uniqueName = solution.Name.ToUniqueName();
                
                var exportSolutionRequest = new ExportSolutionRequest
                {
                    Managed = solution.IsManaged,
                    ExportAutoNumberingSettings = true,
                    ExportCalendarSettings = true,
                    ExportCustomizationSettings = true,
                    ExportEmailTrackingSettings = true,
                    ExportGeneralSettings = true,
                    ExportIsvConfig = true,
                    ExportMarketingSettings = true,
                    ExportOutlookSynchronizationSettings = true,
                    SolutionName = uniqueName
                };


                var exportSolutionResponse = (ExportSolutionResponse)context.Source.Execute(exportSolutionRequest);

                "export of the solution {0} completed.".Trace(uniqueName);
                var exportedXmlFromSource = exportSolutionResponse.ExportSolutionFile;

                if (!string.IsNullOrEmpty(solution.ExportDirectory))
                {
                    try
                    {
                        if (!Directory.Exists(solution.ExportDirectory))
                            Directory.CreateDirectory(solution.ExportDirectory);

                        var fileName = uniqueName + "_" +
                            (Convert.ToDouble(solution.Version)).ToString(CultureInfo.InvariantCulture).ToUniqueName() +
                            ((solution.IsManaged) ? "_managed.zip" : "_unmanaged.zip");

                        using (
                            var fileStream =
                                new FileStream(Path.Combine(solution.ExportDirectory, fileName),
                                    FileMode.Create))
                        {
                            fileStream.Write(exportedXmlFromSource, 0, exportedXmlFromSource.Length);
                            "{0} exported succesfully to path {1}".Trace(uniqueName,
                                solution.ExportDirectory);
                        }

                    }
                    catch (IOException ioex)
                    {
                        ioex.Message.TraceError(ioex);
                    }
                }

                try
                {

                    if (!solution.Publish) continue;
                    var impSolReq = new ImportSolutionRequest()
                    {
                        CustomizationFile = exportedXmlFromSource,
                        OverwriteUnmanagedCustomizations = true,
                        PublishWorkflows = false
                    };

                    "import solution {0} to destination".Trace(uniqueName);
                    context.Destination.Execute(impSolReq);
                    "solution import completed without issue.".Trace();

                    "publishing solution {0}".Trace(uniqueName);
                    if (!solution.IsManaged)
                        context.Destination.Execute(new PublishAllXmlRequest());

                    "the solution {0} has been published successfully.".Trace(uniqueName);
                }
                catch (FaultException<OrganizationServiceFault> orgException)
                {
                    orgException.Message.TraceError(orgException);
                }
            }
        }
    }
}
