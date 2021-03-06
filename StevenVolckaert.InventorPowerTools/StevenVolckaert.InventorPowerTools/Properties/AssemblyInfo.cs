﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Steven Volckaert's Inventor® Power Tools")]
[assembly: AssemblyDescription("A collection of power tools for Autodesk Inventor® 2012.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Steven Volckaert")]
[assembly: AssemblyProduct(StevenVolckaert.InventorPowerTools.AssemblyInfo.Name)]
[assembly: AssemblyCopyright("Copyright © 2016 Steven Volckaert")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid(StevenVolckaert.InventorPowerTools.AssemblyInfo.Guid)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]
[assembly: CLSCompliant(false)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

namespace StevenVolckaert.InventorPowerTools
{
    internal static class AssemblyInfo
    {
        /// <summary>
        /// The application's GUID.
        /// </summary>
        internal const string Guid = "6f046c68-7899-4486-9e15-3752a437a94a";

        /// <summary>
        /// The application's name.
        /// </summary>
        internal const string Name = "Inventor Power Tools";
    }
}
