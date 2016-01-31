// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 07-15-2015
//
// Last Modified By : asifulm
// Last Modified On : 07-15-2015
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Xrm.Sdk;
using Xrm.Solution.Common;

namespace Xrm.Solution.Utility
{
    /// <summary>
    ///     Class XrmFiles.
    /// </summary>
    public static class XrmFiles
    {
        /// <summary>
        ///     Checks if file is type plugin.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns><c>true</c> if plugin, <c>false</c> otherwise.</returns>
        public static bool CheckIfFileIsTypePlugin(string filepath)
        {
            try
            {
                var assembly = Assembly.LoadFile(filepath);
                return assembly.GetModules().Any(c => c.GetTypes().Contains(typeof (IPlugin)));
            }
            catch (IOException ioException)
            {
                ioException.Message.TraceError(ioException);
                return false;
            }
            catch (Exception genericException)
            {
                genericException.Message.TraceError(genericException);
                return false;
            }
        }

        /// <summary>
        ///     Gets the encoded file contents.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns>System.String.</returns>
        public static string GetEncodedFileContents(string pathToFile)
        {
            using (var fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read))
            {
                var binaryData = new byte[fs.Length];
                fs.Read(binaryData, 0, (int) fs.Length);
                return Convert.ToBase64String(binaryData, 0, binaryData.Length);
            }
        }

        /// <summary>
        ///     Gets the files from location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="extensions">The extensions.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public static IEnumerable<string> GetFilesFromLocation(string location, string[] extensions)
        {
            var fileList = new List<string>();
            var queue = new Queue<string>();
            queue.Enqueue(location);

            while (queue.Count != 0)
            {
                var currentLocation = queue.Dequeue();
                var searchPattern = new Regex(GetFilterExpression(extensions), RegexOptions.IgnoreCase);
                fileList.AddRange(Directory.GetFiles(currentLocation).Where(f => searchPattern.IsMatch(f)));

                var subDirectories = Directory.GetDirectories(currentLocation);
                foreach (var directory in subDirectories)
                    queue.Enqueue(directory);
            }

            return fileList;
        }

        /// <summary>
        ///     Gets the filter expression.
        /// </summary>
        /// <param name="extensions">The extensions.</param>
        /// <returns>System.String.</returns>
        public static string GetFilterExpression(string[] extensions)
        {
            var expressionBuilder = new StringBuilder();
            expressionBuilder.Append(@"(?<=\.(");

            foreach (var extension in extensions)
            {
                expressionBuilder.Append(extension).Append("|");
            }
            expressionBuilder.Remove(expressionBuilder.Length - 1, 1);
            expressionBuilder.Append("))");

            return expressionBuilder.ToString();
        }
    }
}