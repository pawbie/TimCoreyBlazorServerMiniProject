using PersonRegistryLibrary.Address;
using PersonRegistryLibrary.Configuration;
using PersonRegistryLibrary.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Services
{
    public class PersonRegistryApiClient : IApiClient
    {

        private readonly IHttpClientFactory _httpFactory;

        public IPersonClient Person { get; }
        public IAddressClient Address { get; }

        public PersonRegistryApiClient(IHttpClientFactory httpFactory)
        {
            _httpFactory = httpFactory;
            Person = new PersonClient(this);
            Address = new AddressClient(this);
        }

        public HttpClient GetClient()
        {
            HttpClient output = _httpFactory.CreateClient();
            return output;
        }
    }
}
