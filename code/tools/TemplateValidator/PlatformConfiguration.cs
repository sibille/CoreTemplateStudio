// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateValidator
{
    public class PlatformConfiguration
    {
        public string Classification { get; set; }

        public Dictionary<string, string[]> Tags { get; set; }

        public string[] Symbols { get; set; }
    }
}
