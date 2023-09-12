using PersonRegistryLibrary.Person.Models;

namespace BlazorPersonRegistry.Helpers
{
    public static class PersonInformationHelper
    {
        public static string DisplayName(this PersonInformation person)
        {
            return $"{person.FirstName} {person.LastName}, {person.Age}";
        }
    }
}
