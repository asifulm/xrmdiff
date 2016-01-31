// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-05-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using System;
using System.Configuration;
using System.Reflection;

namespace Xrm.Solution.Configuration
{
    /// <summary>
    ///     Class ConfigurationElementCollectionBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConfigurationElementCollectionBase<T> : ConfigurationElementCollection
        where T : ConfigurationElement
    {
        /// <summary>
        ///     Gets the type of the <see cref="T:System.Configuration.ConfigurationElementCollection" />.
        /// </summary>
        /// <value>The type of the collection.</value>
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        /// <summary>
        ///     Gets the name used to identify this collection of elements in the configuration file when overridden in a derived
        ///     class.
        /// </summary>
        /// <value>The name of the element.</value>
        protected override string ElementName
        {
            get { return PropertyName; }
        }

        /// <summary>
        ///     Gets the <see cref="DataSourceElement" /> with the specified index.
        /// </summary>
        /// <param name="idx">The index.</param>
        /// <returns>DataSourceElement.</returns>
        public T this[int idx]
        {
            get { return (T) BaseGet(idx); }
        }

        /// <summary>
        ///     Gets the <see cref="T" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>T.</returns>
        public new T this[string name]
        {
            get { return (T) BaseGet(name); }
        }

        /// <summary>
        ///     The property name
        /// </summary>
        /// <value>The name of the property.</value>
        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        public virtual string PropertyName { get; private set; }

        /// <summary>
        ///     When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement" />.
        /// </summary>
        /// <returns>A new <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        ///     Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement" /> to return the key for.</param>
        /// <returns>
        ///     An <see cref="T:System.Object" /> that acts as the key for the specified
        ///     <see cref="T:System.Configuration.ConfigurationElement" />.
        /// </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            var propety = element.GetType().GetProperty("Name", BindingFlags.Public
                                                                | BindingFlags.Instance);

            return propety != null ? propety.GetValue(element) : null;
        }

        /// <summary>
        ///     Indicates whether the specified <see cref="T:System.Configuration.ConfigurationElement" /> exists in the
        ///     <see cref="T:System.Configuration.ConfigurationElementCollection" />.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>true if the element exists in the collection; otherwise, false. The default is false.</returns>
        protected override bool IsElementName(string elementName)
        {
            return string.Compare(PropertyName, elementName, StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}