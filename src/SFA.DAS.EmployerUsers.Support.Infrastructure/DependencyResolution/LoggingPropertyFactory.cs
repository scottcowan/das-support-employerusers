using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Sfa.Das.Console.Infrastructure.DependencyResolution
{
    public class LoggingPropertyFactory : ILoggingPropertyFactory
    {
        public IDictionary<string, object> GetProperties()
        {
            var properties = new Dictionary<string, object>();
            try
            {
                properties.Add("Version", GetVersion());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }
            
            return properties;
        }

        private string GetVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersionInfo.ProductVersion;
        }
    }
}