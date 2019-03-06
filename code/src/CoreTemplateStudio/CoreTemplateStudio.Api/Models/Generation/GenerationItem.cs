﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreTemplateStudio.Api.Models.Generation
{
    public class GenerationItem
    {
        [Required]
        public string Template { get; set; }

        [Required]
        public string Name { get; set; }
    }
}