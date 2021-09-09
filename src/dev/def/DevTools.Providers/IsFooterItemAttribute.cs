﻿using System;
using System.Composition;

namespace DevTools.Providers
{
    /// <summary>
    /// Indicates whether the <see cref="IToolProvider"/> should be displayed at the bottom in the navigation view or not.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class IsFooterItemAttribute : Attribute
    {
        public bool IsFooterItem { get; set; } = true;
    }
}
