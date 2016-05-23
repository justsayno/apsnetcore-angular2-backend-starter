using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnet_core_starter.Configuration;
using Microsoft.Extensions.Options;
using aspnet_core_starter.Models;

namespace aspnet_core_starter.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOptions<FrontendConfig> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        FrontendConfig Options { get; }

        public IActionResult Index()
        {
            string appHash = Options.MainHash;
            string vendorHash = Options.VendorHash;
            string chunkHash = Options.ChunkHash;
            string polyfillsHash = Options.PolyfillsHash;
            string frontendHost = Options.ScriptHost;
            var viewModel = new HomeModel()
            {
                VendorScriptUrl = getScriptUrl("vendor.bundle.js", vendorHash, frontendHost),
                AppScriptUrl = getScriptUrl("main.bundle.js", appHash, frontendHost),
                ChunksScriptUrl = getScriptUrl("1.chunk.js", chunkHash, frontendHost),
                PolyfillsScriptUrl = getScriptUrl("polyfills.bundle.js", polyfillsHash, frontendHost)
            };
            return View(viewModel);
        }

        private string getScriptUrl(string scriptName, string scriptHash, string scriptHost)
        {
            if (string.IsNullOrWhiteSpace(scriptHash)) {
                return $"{scriptHost}/{scriptName}";
            }
            return $"{scriptHost}/{scriptHash}/{scriptName}";
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
