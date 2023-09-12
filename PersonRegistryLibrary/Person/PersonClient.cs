using Newtonsoft.Json;
using PersonRegistryLibrary.Address.Models;
using PersonRegistryLibrary.Configuration;
using PersonRegistryLibrary.General;
using PersonRegistryLibrary.Person.Models;
using PersonRegistryLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Person
{
    public class PersonClient : BaseClient, IPersonClient
    {
        public async Task<List<PersonInformation>> GetAll()
        {
            List<PersonInformation> output;

            var personList = await HandleGetRequest<PersonList>(ConfigurationManager.Endpoints["PersonGetAll"]);
            output = personList.Persons;
            
            return output;
        }

        public async Task<PersonInformation> GetById(int personId)
        {
            PersonInformation output;

            output = await HandleGetRequest<PersonInformation>(ConfigurationManager.Endpoints["PersonGetById", personId.ToString()]);
            return output;
        }

        public async Task<PersonInformation> Create(PersonCreateInformation data)
        {
            PersonInformation output;
            output = await HandlePostRequest<PersonInformation, PersonCreateInformation>(ConfigurationManager.Endpoints["PersonAdd"], data);

            return output;
        }

        public async void Delete(PersonInformation person)
        {
            HandlePostRequest(ConfigurationManager.Endpoints["PersonDelete", person.Id.ToString()]);
        }

        public async Task<PersonInformation> Update(int personId, PersonUpdateInformation person)
        {
            PersonInformation output;

            output = await HandlePostRequest<PersonInformation, PersonUpdateInformation>(ConfigurationManager.Endpoints["PersonUpdate", personId], person);
            return output;
        }

        internal PersonClient(IApiClient api) : base(api)
        {
            
        }
    }
}
