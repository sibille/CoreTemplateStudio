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
    [Verb("file-validate", Hidden = false, HelpText = "Verify a single json file.")]
    public class FileValidationOptions
    {
        [Option('f', "file", Default = "", HelpText = "File Path to validate")]
        public string File { get; set; }

        [Option('c', "config", Default = false, HelpText = "Path to configuration File for Platform specific values")]
        public string ConfigFilePath { get; set; }

        // Warnings should be used to provide guidance in the output but for issues that are optional to address.
        [Option("nowarn", Default = false, HelpText = "Do not show warnings.")]
        public bool NoWarnings { get; set; }
    }
}
