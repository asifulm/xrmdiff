using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Xrm.Solution.Configuration;
using Xrm.Solution.MEF;

namespace Xrm.Solution.Components
{
    [Export(typeof(IXrmXrmDiffUtility))]
    [XrmActivity(Index =200, Description="organization")]
    public class XrmReportGenerator : XrmXrmDiffUtility, IXrmXrmDiffUtility
    {
        /// <summary>
        /// Synchronizes the entities from source to destination.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void ExecuteProcess(XrmActivityContext context)
        {
            if (string.IsNullOrEmpty(context.Configuration.ReportDirectory)) return;

            var changeNo = string.Format("{0:yyyyMMdd}", DateTime.Now);

            var fileName = string.Format("{0}\\{1}.html", context.Configuration.ReportDirectory, changeNo);
            if (!Directory.Exists(context.Configuration.ReportDirectory)) 
                Directory.CreateDirectory(context.Configuration.ReportDirectory);

            if (File.Exists(fileName)) File.Delete(fileName);

            using (var htmlWriter = new StreamWriter(new FileStream(fileName, FileMode.Create)))
            {
                htmlWriter.WriteLine("<html>");
                htmlWriter.WriteLine("<style> body { margin:10px } </style>");
                htmlWriter.WriteLine("<body>");

                htmlWriter.WriteLine("<h1>Change Report</h1>");

                foreach (DataSourceElement element in context.Configuration.DataSources)
                    htmlWriter.WriteLine("<h4>>>" + element.UniqueName + " [" + element.Url +  "]</h4>");

                htmlWriter.WriteLine("<h3>" + DateTime.Now.ToLongDateString() + "</h3>");
                htmlWriter.WriteLine("<hr />");

                foreach (var change in context.ChangeList)
                {
                    if (change.Value.Count == 0) continue;
                    htmlWriter.WriteLine("<h3>" + change.Key.Key + "</h3>");
                    htmlWriter.WriteLine("<hr/>");

                    var diffList = change.Value.OrderBy(c => c.DiffType);

                    htmlWriter.WriteLine("<table>");
                    foreach (var diff in diffList)
                    {
                        htmlWriter.WriteLine("<tr>");
                        var schemaName = diff.Key.Replace("Metadata", "");
                        schemaName = schemaName.Replace("Attributes", "");
                        schemaName = schemaName.Replace("OneToManyRelationships", "");
                        schemaName = schemaName.Replace("ManyToManyRelationships", "");
                        schemaName = schemaName.Replace("ManyToOneRelationships", "");
                        schemaName = schemaName.Replace("ArrayOfEntity", "");
                        schemaName = schemaName.Trim();

                        htmlWriter.Write("<td><b>[" + diff.DiffType + "]\t</b></td>");
                        htmlWriter.Write("<td><i>" + schemaName + "</i>\t</td>");
                        htmlWriter.Write("<td><b>" + diff.Value + "</b></td>");

                        htmlWriter.WriteLine("</tr>");
                    }

                    htmlWriter.WriteLine("</table>");
                    htmlWriter.WriteLine("<hr/>");
                }

                htmlWriter.WriteLine("</html>");
                htmlWriter.WriteLine("</body>");
            }

            Process.Start(fileName);
        }
    }
}
