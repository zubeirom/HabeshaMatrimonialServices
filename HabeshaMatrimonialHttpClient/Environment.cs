using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient
{
    class Environment
    {
        string OcpApimKey { get; }
        string BaseUrl { get; }

        public Environment()
        {
            System.Environment.SetEnvironmentVariable("OCP_APIM_KEY", "9457ca7fc0ab4d56a36a8478f7cae989");
            System.Environment.SetEnvironmentVariable("BASE_URL", "https://westus.api.cognitive.microsoft.com");

            this.OcpApimKey = System.Environment.GetEnvironmentVariable("OCP_APIM_KEY");
            this.BaseUrl = System.Environment.GetEnvironmentVariable("BASE_URL");
        }

        public string OCP_APIM_KEY()
        {
            return this.OcpApimKey;
        }

        public string BASE_URL()
        {
            return this.BaseUrl;
        }

    }
}
