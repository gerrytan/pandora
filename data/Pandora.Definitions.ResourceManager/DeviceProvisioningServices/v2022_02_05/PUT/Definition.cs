using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DeviceProvisioningServices.v2022_02_05.PUT;

internal class Definition : ResourceDefinition
{
    public string Name => "PUT";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DpsCertificateCreateOrUpdateOperation(),
        new IotDpsResourceCreateOrUpdateOperation(),
        new IotDpsResourceCreateOrUpdatePrivateEndpointConnectionOperation(),
    };
}
