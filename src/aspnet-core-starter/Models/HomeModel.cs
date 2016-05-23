using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_starter.Models
{
    public class HomeModel
    {
        public string AppScriptUrl { get; set; }
        public string VendorScriptUrl { get; set; }
        public string ChunksScriptUrl { get; set; }
        public string PolyfillsScriptUrl { get; set; }
    }
}
