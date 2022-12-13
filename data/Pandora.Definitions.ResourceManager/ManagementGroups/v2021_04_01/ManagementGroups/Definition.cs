using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ManagementGroups.v2021_04_01.ManagementGroups;

internal class Definition : ResourceDefinition
{
    public string Name => "ManagementGroups";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetDescendantsOperation(),
        new HierarchySettingsCreateOrUpdateOperation(),
        new HierarchySettingsDeleteOperation(),
        new HierarchySettingsGetOperation(),
        new HierarchySettingsListOperation(),
        new HierarchySettingsUpdateOperation(),
        new ListOperation(),
        new UbscriptionsCreateOperation(),
        new UbscriptionsDeleteOperation(),
        new UbscriptionsGetSubscriptionOperation(),
        new UbscriptionsGetSubscriptionsUnderManagementGroupOperation(),
        new UpdateOperation(),
    };
}
