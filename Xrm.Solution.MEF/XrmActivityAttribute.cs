// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using System;
using System.ComponentModel.Composition;

namespace Xrm.Solution.MEF
{
    /// <summary>
    /// Class XrmActivityAttribute.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class XrmActivityAttribute : Attribute, IXrmActivity
    {
        public string Description { get; set; }

        public int Index { get; set; }

    }


    public interface IXrmActivity
    {
        string Description { get; }
        int Index { get; }
    }
}