using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.ApiOperation;


internal class OperationContractPropertiesModel
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    [Required]
    public string DisplayName { get; set; }

    [JsonPropertyName("method")]
    [Required]
    public string Method { get; set; }

    [JsonPropertyName("policies")]
    public string? Policies { get; set; }

    [JsonPropertyName("request")]
    public RequestContractModel? Request { get; set; }

    [JsonPropertyName("responses")]
    public List<ResponseContractModel>? Responses { get; set; }

    [JsonPropertyName("templateParameters")]
    public List<ParameterContractModel>? TemplateParameters { get; set; }

    [JsonPropertyName("urlTemplate")]
    [Required]
    public string UrlTemplate { get; set; }
}
