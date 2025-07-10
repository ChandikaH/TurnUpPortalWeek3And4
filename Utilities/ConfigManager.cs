using System.IO;
using Newtonsoft.Json.Linq;

namespace TurnUpPortalWeek3And4.Utilities
{
    public static class ConfigManager
    {
        private static JObject config;

        static ConfigManager()
        {
            var json = File.ReadAllText("Config/appsettings.json");
            config = JObject.Parse(json);
        }

        public static string Get(string key)
        {
            return config[key]?.ToString();
        }
    }
}