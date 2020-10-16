// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace TemplateValidator
{
    [Verb("folder-validate", Hidden = false, HelpText = "Verify all the templates in the defined directories.")]
    public class FolderValidationOptions
    {
        // Use arral rather than List<T> becuase the CommandLineParser interprets ':' in a special way for parsing list items but we need it for file paths
        [Option('d', "directories", Default = new string[] { }, HelpText = "Verify all the templates in the defined directories.")]
        public IEnumerable<string> Directories { get; set; }

        // Warnings should be used to provide guidance in the output but for issues that are optional to address.
        [Option("checkPrimaryOutput", Default = false, HelpText = "Check outputPaths are defined")]
        public bool CheckPrimaryOutput { get; set; }

        // Warnings should be used to provide guidance in the output but for issues that are optional to address.
        [Option("nowarn", Default = false, HelpText = "Do not show warnings.")]
        public bool NoWarnings { get; set; }
    }
}
