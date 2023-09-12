using PersonRegistryLibrary.Address.Models;
using PersonRegistryLibrary.Configuration;
using PersonRegistryLibrary.General;
using PersonRegistryLibrary.Person.Models;
using PersonRegistryLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Address
{
    public class AddressClient : BaseClient, IAddressClient
    {
        public async Task<List<AddressInformation>> GetByPerson(int personId)
        {
            List<AddressInformation> output;

            var addressList = await HandleGetRequest<AddressList>(ConfigurationManager.Endpoints["AddressGetAll", personId]);
            output = addressList.Addresses;
            return output;
        }

        public async Task<AddressInformation> AddToPerson(int personId, AddressCreateInformation data)
        {
            AddressInformation output;

            output = await HandlePostRequest<AddressInformation, AddressCreateInformation>(ConfigurationManager.Endpoints["AddressAdd", personId], data);
            return output;
        }

        public async void RemoveFromPerson(int addressId)
        {
            HandlePostRequest(ConfigurationManager.Endpoints["AddressRemove", addressId]);
        }

        public async Task<AddressInformation> Update(int addressId, AddressUpdateInformation newData)
        {
            AddressInformation output;

            output = await HandlePostRequest<AddressInformation, AddressUpdateInformation>(ConfigurationManager.Endpoints["AddressUpdate", addressId], newData);
            return output;
        }

        internal AddressClient(IApiClient api) : base(api)
        {
            
        }
    }
}
