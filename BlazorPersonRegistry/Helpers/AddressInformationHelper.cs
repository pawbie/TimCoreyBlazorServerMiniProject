using PersonRegistryLibrary.Address.Models;
using PersonRegistryLibrary.Person.Models;

namespace BlazorPersonRegistry.Helpers
{
    public static class AddressInformationHelper
    {
        public static string DisplayName(this AddressInformation address)
        {
            return $"{address.Street}, {address.PostalCode} {address.City}";
        }
    }
}
