using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Address.Models
{
    internal class AddressList
    {
        [JsonProperty("data")]
        public List<AddressInformation> Addresses { get; set; }
    }
}
