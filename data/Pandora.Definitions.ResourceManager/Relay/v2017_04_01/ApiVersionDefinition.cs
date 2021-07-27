using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Relay.v2017_04_01
{
    public partial class Definition : ApiVersionDefinition
    {
        public string ApiVersion => "2017-04-01";
        public bool Preview => false;

        public IEnumerable<ApiDefinition> Apis => new List<ApiDefinition>
        {
            new HybridConnections.Definition(),
            new Namespaces.Definition(),
            new WCFRelays.Definition(),
        };
    }
}
