using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Services
{
    public class ObjectMapperService : IObjectMapper
    {
        public UTarget MapTo<TSource, UTarget>(TSource obj)
            where TSource: class
            where UTarget: class
        {
            var sourceProprties = obj.GetType().GetProperties();
            var targetObj = Activator.CreateInstance(typeof(UTarget)) as UTarget;

            foreach (var prop in sourceProprties)
            {
                if (targetObj.GetType().GetProperty(prop.Name) != null)
                {
                    targetObj.GetType().GetProperty(prop.Name).SetValue(targetObj, prop.GetValue(obj, null));
                }
            }

            return targetObj;
        }
    }
}
