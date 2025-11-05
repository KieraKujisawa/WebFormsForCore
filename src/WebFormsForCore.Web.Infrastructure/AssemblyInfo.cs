using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", Justification = "This version attribute is not parsed")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyProduct("WebFormsForCore")]
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Assembly is delay-signed")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Web.Infrastructure", Justification = "The types in this namespace aren't meant to be called by user code.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Web.Infrastructure.DynamicModuleHelper", Justification = "The types in this namespace aren't meant to be called by user code.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Web.Infrastructure.DynamicValidationHelper", Justification = "The types in this namespace aren't meant to be called by user code.")]
[assembly: AssemblyTitle("Microsoft.Web.Infrastructure")]
[assembly: AssemblyDescription("")]
[assembly: AllowPartiallyTrustedCallers]
