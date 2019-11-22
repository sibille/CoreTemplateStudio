﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.Templates.Core.Naming
{
    public class ItemNameService
    {
        private readonly List<Validator> _validators = new List<Validator>();

        public ItemNameService(ItemNameValidationConfig config, Func<IEnumerable<string>> getExisitingNames)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(ItemNameValidationConfig));
            }

            if (config.Regexs != null)
            {
                foreach (var regexValidation in config.Regexs)
                {
                    _validators.Add(new RegExValidator(regexValidation));
                }
            }

            if (config.ReservedNames != null && config.ReservedNames.Length > 0)
            {
                _validators.Add(new ReservedNamesValidator(config.ReservedNames));
            }

            if (config.ValidateDefaultNames)
            {
                _validators.Add(new DefaultNamesValidator());
            }

            if (config.ValidateEmptyNames)
            {
                _validators.Add(new EmptyNameValidator());
            }

            if (config.ValidateExistingNames)
            {
                _validators.Add(new ExistingNamesValidator(getExisitingNames));
            }
        }

        public string Infer(string suggestedName)
        {
            return NamingService.Infer(suggestedName, _validators);
        }

        public ValidationResult Validate(string value)
        {
            return NamingService.Validate(value, _validators);
        }
    }
}
