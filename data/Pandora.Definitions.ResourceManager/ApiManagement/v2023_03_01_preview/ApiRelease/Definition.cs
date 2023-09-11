using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.ApiRelease;

internal class Definition : ResourceDefinition
{
    public string Name => "ApiRelease";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetEntityTagOperation(),
        new ListByServiceOperation(),
        new UpdateOperation(),
        new WorkspaceApiReleaseCreateOrUpdateOperation(),
        new WorkspaceApiReleaseDeleteOperation(),
        new WorkspaceApiReleaseGetOperation(),
        new WorkspaceApiReleaseGetEntityTagOperation(),
        new WorkspaceApiReleaseListByServiceOperation(),
        new WorkspaceApiReleaseUpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ApiReleaseContractModel),
        typeof(ApiReleaseContractPropertiesModel),
    };
}
