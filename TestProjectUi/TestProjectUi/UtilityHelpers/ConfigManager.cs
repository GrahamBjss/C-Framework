using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProjectUi.UtilityHelpers
{
    public class ConfigManager
    {
        public static string BrowsersType => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build().GetSection("Browsers")["Browser"];

        public static string WebSiteUrl => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build().GetSection("WebSiteUrl")["url"];
    }
}