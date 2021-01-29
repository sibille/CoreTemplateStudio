﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Templates.Core
{
    public class Platform
    {
        public string Id { get; set; }

        public Dictionary<string, string> Options { get; private set; } = new Dictionary<string, string>();

        public Platform(string id)
        {
            Id = id;
        }

        public Platform(string id, Dictionary<string, string> options)
        {
            Id = id;
            Options = options;
        }
    }
}
