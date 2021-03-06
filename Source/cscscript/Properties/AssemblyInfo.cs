using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("C# Script engine Console executable")]
#if net1
[assembly: AssemblyDescription("C# Script engine (.NET 1.1 build)")]
#else
[assembly: AssemblyDescription("C# Script engine Console executable")]
#endif
[assembly: AssemblyConfiguration("")]

[assembly: AssemblyProduct("C# Script engine")]
[assembly: AssemblyCopyright("(C) 2004-2017 Oleg Shilo")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if dev
[assembly: InternalsVisibleTo("Tests")]
#endif
// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("8afbd3fc-0a39-4db5-b592-b2981982b33d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("3.25.2.0")]
[assembly: AssemblyFileVersion("3.25.2.0")]