using PersonRegistryLibrary.Address.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Address
{
    public interface IAddressClient
    {
        Task<List<AddressInformation>> GetByPerson(int personId);
        Task<AddressInformation> AddToPerson(int personId, AddressCreateInformation data);
        void RemoveFromPerson(int addressId);
        Task<AddressInformation> Update(int addressId, AddressUpdateInformation newData);
    }
}
