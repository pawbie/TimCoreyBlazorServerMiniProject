using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Configuration
{
    public class EndpointConfiguration : IEndpointConfiguration
    {
        private readonly Dictionary<string, string> _endpoints = new();
        private readonly string _baseUrl = @"";


        public Uri this[string key, params object?[] args] => new Uri(BaseUrl + string.Format(_endpoints[key], args));

        public string BaseUrl => _baseUrl;

        public EndpointConfiguration()
        {
            _endpoints.Add("PersonGetAll", "/person");
            _endpoints.Add("PersonGetById", "/person/{0}");
            _endpoints.Add("PersonAdd", "/person/create");
            _endpoints.Add("PersonDelete", "/person/{0}/delete");
            _endpoints.Add("PersonUpdate", "/person/{0}/update");

            _endpoints.Add("AddressGetAll", "/person/{0}/address");
            _endpoints.Add("AddressGetById", "/person/{0}/address{1}");
            _endpoints.Add("AddressAdd", "/person/{0}/address/create");
            _endpoints.Add("AddressUpdate", "/person/{0}/address/{1}/update");
            _endpoints.Add("AddressDelete", "/person/{0}/address/{1}/delete");

        }
    }
}
