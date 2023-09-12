using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Services
{
    public interface IObjectMapper
    {
        U MapTo<T, U>(T obj)
            where T : class
            where U : class;
    }
}
