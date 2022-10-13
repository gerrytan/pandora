using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2022_05_01.StorageAccounts;


internal class StorageAccountUpdateParametersModel
{
    [JsonPropertyName("identity")]
    public CustomTypes.LegacySystemAndUserAssignedIdentityMap? Identity { get; set; }

    [JsonPropertyName("kind")]
    public KindConstant? Kind { get; set; }

    [JsonPropertyName("properties")]
    public StorageAccountPropertiesUpdateParametersModel? Properties { get; set; }

    [JsonPropertyName("sku")]
    public SkuModel? Sku { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }
}
