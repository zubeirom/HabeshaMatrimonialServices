using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient.Interfaces
{
    class JsonHttpClient : IHttpClient
    {
        HttpClient client;
        string ocpApimKey;
        string baseUrl;

        public JsonHttpClient()
        {
            this.baseUrl = ConfigurationManager.AppSettings["baseUrl"];
            this.ocpApimKey = ConfigurationManager.AppSettings["ocpApimKey"];
            this.client = new HttpClient()
            {
                BaseAddress = new Uri(this.baseUrl)
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", this.ocpApimKey);

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Patch()
        {
            throw new NotImplementedException();
        }

        public void Post()
        {
            throw new NotImplementedException();
        }

        public void Put()
        {
            throw new NotImplementedException();
        }
    }
}
