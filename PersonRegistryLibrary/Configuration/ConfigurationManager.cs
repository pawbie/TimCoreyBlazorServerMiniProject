using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Configuration
{
    internal static class ConfigurationManager
    {
        private static IEndpointConfiguration endpoints = new EndpointConfiguration();

        public static IEndpointConfiguration Endpoints => endpoints;
    }
}
