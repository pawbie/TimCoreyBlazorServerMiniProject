using PersonRegistryLibrary.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PersonRegistryLibrary.Services;
using System.Net.Http.Json;

namespace PersonRegistryLibrary.General
{
    public abstract class BaseClient
    {
        protected readonly IApiClient _api;

        internal BaseClient(IApiClient api)
        {
            _api = api;
        }

        protected async Task<T> HandleGetRequest<T>(Uri uri)
        {
            var http = _api.GetClient();
            T output;

            try
            {
                output = JsonConvert.DeserializeObject<T>(await http.GetStringAsync(uri));
                return output;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected async Task<T> HandlePostRequest<T, U>(Uri uri, U? body = default(U))
        {
            var http = _api.GetClient();

            T output;
            HttpResponseMessage message;
            HttpContent req;

            try
            {
                req = body == null ? null : JsonContent.Create<U>(body);
                using (var response = await http.PostAsync(uri, req))
                {
                    output = JsonConvert.DeserializeObject < T > (await response.Content.ReadAsStringAsync());
                    return output;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected async void HandlePostRequest(Uri uri)
        {
            var http = _api.GetClient();

            try
            {
                await http.PostAsync(uri, null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
