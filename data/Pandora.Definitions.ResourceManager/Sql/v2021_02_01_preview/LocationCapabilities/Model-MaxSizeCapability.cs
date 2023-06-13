using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2021_02_01_preview.LocationCapabilities;


internal class MaxSizeCapabilityModel
{
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("unit")]
    public MaxSizeUnitConstant? Unit { get; set; }
}
