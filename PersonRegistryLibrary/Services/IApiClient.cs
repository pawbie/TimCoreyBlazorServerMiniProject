using PersonRegistryLibrary.Address;
using PersonRegistryLibrary.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Services
{
    public interface IApiClient
    {
        IPersonClient Person { get; }
        IAddressClient Address { get; }

        HttpClient GetClient();
    }
}
