using PersonRegistryLibrary.Configuration;
using PersonRegistryLibrary.Person.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Person
{
    public interface IPersonClient
    {
        Task<List<PersonInformation>> GetAll();
        Task<PersonInformation> GetById(int personId);
        Task<PersonInformation> Create(PersonCreateInformation data);
        void Delete(PersonInformation person);
        Task<PersonInformation> Update(int personId, PersonUpdateInformation person);
    }
}
