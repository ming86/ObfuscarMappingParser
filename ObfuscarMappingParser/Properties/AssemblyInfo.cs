﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ObfuscarMappingParser")]
[assembly: AssemblyDescription("Obfuscar crashlogs processor")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Broken Event")]
[assembly: AssemblyProduct("ObfuscarMappingParser")]
[assembly: AssemblyCopyright("© 2014-2019 Broken Event. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("780b9d0e-cc2c-4a49-8368-07b801482a7d")]

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
[assembly: AssemblyVersion("1.0.2.2756")]
[assembly: AssemblyFileVersion("1.0.2.2756")]

#if DEBUG
[assembly: InternalsVisibleTo("MappingParser.Tests", AllInternalsVisible = true)]
#endif
