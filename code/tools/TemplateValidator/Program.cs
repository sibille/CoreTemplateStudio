// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace TemplateValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args?.Any() != false)
            {
                var appTitle = new HelpText
                {
                    Heading = HeadingInfo.Default,
                    Copyright = CopyrightInfo.Default,
                    AdditionalNewLineAfterOption = true,
                    AddDashesToOption = true,
                };
                Console.WriteLine(appTitle);
                VerifierResult results = null;

                var parsedArgs = Parser.Default.ParseArguments<FolderValidationOptions, FileValidationOptions>(args);
                results = parsedArgs.MapResult(
                    (FolderValidationOptions folderOptions) => { return TemplateFolderVerifier.VerifyTemplateFolders(!folderOptions.NoWarnings, folderOptions.CheckPrimaryOutput, folderOptions.Directories); },
                    (FileValidationOptions fileOptions) => { return TemplateJsonVerifier.VerifyTemplatePathAsync(fileOptions.File, fileOptions.ConfigFilePath).Result; },
                    errors =>
                    {
                        var helpText = HelpText.AutoBuild(parsedArgs);
                        Console.WriteLine(helpText);
                        return results;
                    });

                if (results != null)
                {
                    foreach (var result in results.Messages)
                    {
                        Console.WriteLine(result);
                    }
                }

                Console.ReadKey(true);
            }
        }
    }
}
