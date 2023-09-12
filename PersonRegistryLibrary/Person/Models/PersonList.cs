using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Person.Models
{
    public class PersonList
    {
        [JsonProperty("data")]
        public List<PersonInformation> Persons { get; set; }
    }
}
