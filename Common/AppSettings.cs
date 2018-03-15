using System;
using System.IO;
// Requires NuGet package
// Microsoft.Extensions.Configuration.Json
using Microsoft.Extensions.Configuration;

namespace BillingSuport.Common {
    public class TMAppSettings {
        private IConfigurationRoot _IConfigurationRoot;
        public TMAppSettings(string json = "appsettings.json") {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(json);
            _IConfigurationRoot = builder.Build();
        }
        public IConfigurationSection GetSection(string MainSection, string KeySection) {
            return _IConfigurationRoot.GetSection($"{MainSection}:{KeySection}");
        }
        public System.Collections.Generic.KeyValuePair<string, string> GetSection(string MainSection, string KeySection, string obj) {
            var rs = _IConfigurationRoot.GetSection($"{MainSection}:{KeySection}");
            return new System.Collections.Generic.KeyValuePair<string, string>(rs.Key, rs.Value);
        }
        public string GetSectionConnectionStrings(string ConnectionStrings = "MainConnection") {
            return _IConfigurationRoot.GetSection($"ConnectionStrings:{ConnectionStrings}").Value;
        }
    }
}