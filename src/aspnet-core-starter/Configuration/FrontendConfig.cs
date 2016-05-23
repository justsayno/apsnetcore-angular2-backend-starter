
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_starter.Configuration
{
    public class FrontendConfig
    {
        public string MainHash { get; set; }
        public string VendorHash { get; set; }
        public string PolyfillsHash { get; set; }
        public string ChunkHash { get; set; }
        public string ScriptHost { get; set; }
    }
}
