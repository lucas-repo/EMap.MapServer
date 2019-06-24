using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpMapServer.Creator
{
    public class JsonSettings
    {
        public IConfigurationRoot ConfigurationRoot { get; }
        private JsonSettings()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("SharpMapServer.Creator.json");
            ConfigurationRoot = builder.Build();
        }
        private static JsonSettings _defaultSettings;
        public static JsonSettings DefaultSettings
        {
            get
            {
                if (_defaultSettings == null)
                {
                    _defaultSettings = new JsonSettings();
                }
                return _defaultSettings;
            }
        }
        public string GetConnectionString(string name)
        {
            string connection = ConfigurationRoot.GetConnectionString(name);
            return connection;
        }
        public T GetValue<T>(string name)
        {
            T value = ConfigurationRoot.GetValue<T>(name);
            return value;
        }
    }
}
