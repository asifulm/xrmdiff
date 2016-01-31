using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using Xrm.Solution.Common;
using Xrm.Solution.Configuration;
using Xrm.Solution.MEF;
using Xrm.Solution.Utility;

namespace XrmDiffUtility
{
    [Export]
    public class SolutionDiffComponents
    {
        [ImportMany(typeof(IXrmXrmDiffUtility))]
        public IEnumerable<Lazy<XrmXrmDiffUtility, IXrmActivity>> Components { get; set; }

        public bool Execute(XrmConfiguration configuration)
        {
            try
            {
                "initializing connections.".Trace();
                var context = new XrmActivityContext()
                {
                    Configuration = configuration,
                    Source = new XrmConnectionManager().GetConnection(configuration.DataSources["source"]),
                    Destination = new XrmConnectionManager().GetConnection(configuration.DataSources["destination"])
                };

                foreach (var component in Components.OrderBy(c => c.Metadata.Index))
                {
                    "processing {0}".Trace(component.Metadata.Description);
                    component.Value.ExecuteProcess(context);
                }

                return true;
            }
            catch (FaultException<OrganizationServiceFault> orgex)
            {
                orgex.Message.TraceError(orgex);
            }
            catch (Exception ex)
            {
                ex.Message.TraceError(ex);
            }

            return false;
        }
    }
}
