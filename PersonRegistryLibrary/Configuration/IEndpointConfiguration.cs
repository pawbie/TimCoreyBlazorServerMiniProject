using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Configuration
{
    public interface IEndpointConfiguration
    {
        public string BaseUrl { get; }

        Uri this[string key, params object?[] args] { get; }
    }
}
