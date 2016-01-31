// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-24-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-24-2015
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Xrm.Solution.Utility
{
    /// <summary>
    /// Class DiffXml.
    /// </summary>
    public class DiffXrmXml
    {

        /// <summary>
        /// The list of exceptions
        /// </summary>
        public static string[] @Exceptions = {"createdon", "solutionid", "key",
                                      "modifiedon", "createdon",
                                      "createdby", "modifiedby",
                                      "id", "metadataid",
                                      "objecttypecode", "organizationid",
                                      "systemuserid", "businessunitid",
                                      "componentstate", "iscustomizable",
                                      "owningbusinessunit", "ownerid",
                                      "statecode", "owninguser",
                                      "columnnumber", "businessunit",
                                      "versionnumber", "category",
                                      "ismanaged", "idunique",
                                      "languagecode", "haschanged",
                                      "deprecatedversion", "order",
                                      "introducedversion", "securitytypes", "isauditenabled",
                                      "LogicalName", "string" };

        /// <summary>
        /// The schema name
        /// </summary>
        public const string SchemaName = "SchemaName";
        /// <summary>
        /// The separator
        /// </summary>
        public const string Separator = "\t";

        /// <summary>
        /// Generates the XML tree.
        /// </summary>
        /// <param name="firstNode">The first node.</param>
        /// <returns>Dictionary&lt;System.String, System.String&gt;.</returns>
        private Dictionary<string, string> GenerateXmlTree(XmlNode firstNode)
        {
            var xmlTreeList = new Dictionary<string, string>();

            var nodeQueue = new Queue<KeyValuePair<string, XmlNode>>();
            nodeQueue.Enqueue(new KeyValuePair<string, XmlNode>(firstNode.Name, firstNode));

            while (nodeQueue.Count != 0)
            {
                var pair = nodeQueue.Dequeue();

                var elementName = GetSchemaName(pair.Value);
                var path = !string.IsNullOrEmpty(elementName) ? pair.Key + Separator + elementName : pair.Key;
                foreach (XmlNode childNode in pair.Value.ChildNodes)
                {
                    if (childNode.HasChildNodes)
                    {
                        if (childNode.Name.StartsWith("KeyValuePairOf"))
                        {
                            var keyvaluepair = GetKeyValuePair(childNode);
                            xmlTreeList[path + Separator + keyvaluepair.Key] = GetValue(keyvaluepair.Value);
                        }
                        else
                        {
                            nodeQueue.Enqueue(
                                new KeyValuePair<string, XmlNode>(path + Separator + childNode.Name, childNode));
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(childNode.InnerText))
                            xmlTreeList[path] = GetValue(childNode.InnerText);
                    }
                }

            }

            return xmlTreeList;
        }


        private static string GetValue(string value)
        {
            DateTime currentDate;
            return DateTime.TryParse(value, out currentDate) ? string.Empty : value;
        }

        /// <summary>
        /// Gets the name of the schema.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>System.String.</returns>
        private static KeyValuePair<string, string> GetKeyValuePair(XmlNode node)
        {
            var name = (from XmlNode childNode in node.ChildNodes
                        where childNode.Name.EndsWith("key")
                        select childNode.InnerText).FirstOrDefault();

            var value = (from XmlNode childNode in node.ChildNodes
                         where childNode.Name.EndsWith("value")
                         select childNode.InnerText).FirstOrDefault();

            return new KeyValuePair<string, string>(name, value);
        }


        /// <summary>
        /// Gets the name of the schema.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>System.String.</returns>
        private static string GetSchemaName(XmlNode node)
        {
            return (from XmlNode childNode in node.ChildNodes
                    where string.Compare(childNode.Name, SchemaName, StringComparison.OrdinalIgnoreCase) == 0
                    select childNode.InnerText).FirstOrDefault();
        }

        /// <summary>
        /// Gets the difference between to different xml nodes
        /// </summary>
        /// <param name="firstNode">The first node.</param>
        /// <param name="secondNode">The second node.</param>
        /// <param name="exceptions">The exceptions.</param>
        /// <returns>IEnumerable&lt;DiffData&gt;.</returns>
        public IEnumerable<DiffItem> GetDifference(XmlNode firstNode, XmlNode secondNode, params string[] exceptions)
        {
            var changeList = new List<DiffItem>();

            RemoveExceptions(firstNode, exceptions);
            RemoveExceptions(secondNode, exceptions);

            var firstNodeTree = GenerateXmlTree(firstNode);
            var secondNodeTree = GenerateXmlTree(secondNode);

            foreach (var keyNode1 in firstNodeTree)
            {
                if (string.IsNullOrEmpty(keyNode1.Value))
                {
                    secondNodeTree.Remove(keyNode1.Key);
                    continue;
                }
                var isDifferent = !secondNodeTree.ContainsKey(keyNode1.Key);

                if (isDifferent)
                {
                    changeList.Add(new DiffItem
                    {
                        DiffType = DiffType.Added,
                        Value = keyNode1.Value,
                        Key = keyNode1.Key
                    });
                    continue;
                }

                isDifferent |= !secondNodeTree[keyNode1.Key].Equals(keyNode1.Value);

                if (isDifferent)
                {
                    changeList.Add(new DiffItem
                    {
                        DiffType = DiffType.Edited,
                        Value = keyNode1.Value,
                        Key = keyNode1.Key
                    });
                }

                secondNodeTree.Remove(keyNode1.Key);
            }

            changeList.AddRange(secondNodeTree.Select(keyNode2 => new DiffItem
            {
                DiffType = DiffType.Removed,
                Value = keyNode2.Value,
                Key = keyNode2.Key
            }));

            return changeList;
        }

        /// <summary>
        /// Removes the exceptions.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="exceptions">The exceptions.</param>
        private void RemoveExceptions(XmlNode node, params string[] exceptions)
        {
            var nodeStack = new Stack<XmlNode>();
            nodeStack.Push(node);

            var removeNodeDictionary = new List<KeyValuePair<XmlNode, XmlNode>>();

            while (nodeStack.Count != 0)
            {
                var element = nodeStack.Pop();
                var parent = element.ParentNode;
                var elementNodeName = element.Name.ToLower();

                foreach (XmlNode childNode in element.ChildNodes)
                {
                    nodeStack.Push(childNode);
                }

                var foundException =
                    exceptions.Any(c => string.Compare(element.Name,
                        c, StringComparison.CurrentCultureIgnoreCase) == 0);

                foundException |= exceptions.Any(c => (elementNodeName.EndsWith(c)
                                                        || elementNodeName.StartsWith(c)));
                if (!foundException) continue;
                if (parent != null) removeNodeDictionary.Add(new KeyValuePair<XmlNode, XmlNode>(parent, element));
            }


            foreach (var removeNode in removeNodeDictionary)
            {
              if (removeNode.Value.ParentNode != null)  removeNode.Key.RemoveChild(removeNode.Value);
            }
        }
    }

    /// <summary>
    /// Struct DiffData
    /// </summary>
    public struct DiffItem
    {
        /// <summary>
        /// Gets or sets the type of the difference.
        /// </summary>
        /// <value>The type of the difference.</value>
        public DiffType DiffType { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The key.</value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
    }

    /// <summary>
    /// Enum DiffType
    /// </summary>
    public enum DiffType
    {
        /// <summary>
        /// A new item was added
        /// </summary>
        Added,

        /// <summary>
        /// The item has been edited.
        /// </summary>
        Edited,

        /// <summary>
        /// A delete as occurred
        /// </summary>
        Removed
    }
}
