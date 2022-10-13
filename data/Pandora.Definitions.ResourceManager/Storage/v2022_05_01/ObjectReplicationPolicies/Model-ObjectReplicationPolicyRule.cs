using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2022_05_01.ObjectReplicationPolicies;


internal class ObjectReplicationPolicyRuleModel
{
    [JsonPropertyName("destinationContainer")]
    [Required]
    public string DestinationContainer { get; set; }

    [JsonPropertyName("filters")]
    public ObjectReplicationPolicyFilterModel? Filters { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    [JsonPropertyName("sourceContainer")]
    [Required]
    public string SourceContainer { get; set; }
}
