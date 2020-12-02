// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:PrefixLocalCallsWithThis", Justification = "We follow the C# Core Coding Style which avoids using `this` unless absolutely necessary.")]

[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1200:UsingDirectivesMustBePlacedWithinNamespace", Justification = "We follow the C# Core Coding Style which puts using statements outside the namespace.")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "It is not a priority and have hight impact in code changes.")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:ElementsMustBeOrderedByAccess", Justification = "It is not a priority and have hight impact in code changes.")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1203:ConstantsMustAppearBeforeFields", Justification = "It is not a priority and have hight impact in code changes.")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1204:StaticElementsMustAppearBeforeInstanceElements", Justification = "It is not a priority and have hight impact in code changes.")]

[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:FieldNamesMustNotBeginWithUnderscore", Justification = "We follow the C# Core Coding Style which uses underscores as prefixes rather than using `this.`.")]

[assembly: SuppressMessage("StyleCop.CSharp.SpecialRules", "SA0001:XmlCommentAnalysisDisabled", Justification = "Not enabled as we don't want or need XML documentation.")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1629:DocumentationTextMustEndWithAPeriod", Justification = "Not enabled as we don't want or need XML documentation.")]

[assembly: SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly", Scope = "member", Target = "~E:Microsoft.Templates.Core.Locations.TemplatesSynchronization.SyncStatusChanged", Justification = "Using an Action<object, SyncStatusEventArgs> does not allow the required notation")]

// Non general supressions
[assembly: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "We need to have the names of these keys in lowercase to be able to compare with the keys becoming form the template json. ContainsKey does not allow StringComparer especification to IgnoreCase", Scope = "member", Target = "~M:Microsoft.Templates.Core.ITemplateInfoExtensions.GetQueryableProperties(Microsoft.TemplateEngine.Abstractions.ITemplateInfo)~Microsoft.Templates.Core.Composition.QueryablePropertyDictionary")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "We need to have the names of these keys in lowercase to be able to compare with the keys becoming form the template json. ContainsKey does not allow StringComparer especification to IgnoreCase", Scope = "member", Target = "~M:Microsoft.Templates.Core.Composition.CompositionQuery.Match(System.Collections.Generic.IEnumerable{Microsoft.Templates.Core.Composition.QueryNode},Microsoft.Templates.Core.Composition.QueryablePropertyDictionary)~System.Boolean")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Templates.Core.Locations.JunctionNativeMethods.ThrowLastWin32Error(System.String)", Scope = "member", Target = "~M:Microsoft.Templates.Core.Locations.JunctionNativeMethods.DeleteJunction(System.String)", Justification = "Only used for local generation")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Templates.Core.Locations.JunctionNativeMethods.ThrowLastWin32Error(System.String)", Scope = "member", Target = "~M:Microsoft.Templates.Core.Locations.JunctionNativeMethods.InternalGetTarget(Microsoft.Win32.SafeHandles.SafeFileHandle)~System.String", Justification = "Only used for local generation")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Templates.Core.Locations.JunctionNativeMethods.ThrowLastWin32Error(System.String)", Scope = "member", Target = "~M:Microsoft.Templates.Core.Locations.JunctionNativeMethods.OpenReparsePoint(System.String,Microsoft.Templates.Core.Locations.JunctionNativeMethods.EFileAccess)~Microsoft.Win32.SafeHandles.SafeFileHandle", Justification = "Only used for local generation")]
