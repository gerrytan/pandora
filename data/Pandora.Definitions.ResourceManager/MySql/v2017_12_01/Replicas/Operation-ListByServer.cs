using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MySql.v2017_12_01.Replicas;

internal class ListByServerOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new ServerId();

    public override Type? ResponseObject() => typeof(ServerListResultModel);

    public override string? UriSuffix() => "/replicas";


}
