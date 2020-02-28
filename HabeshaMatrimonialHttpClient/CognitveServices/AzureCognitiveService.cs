using HabeshaMatrimonialStorage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient.CognitveServices
{
    class AzureCognitiveService : IFaceVerification
    {
        readonly Environment env;

        public AzureCognitiveService(Environment env)
        {
            this.env = env;
        }

        public async Task<String> Detect(string imageUrlPath)
        {
            try
            {
                var key = this.env.OCP_APIM_KEY();
                var client = new HttpClient
                {
                    BaseAddress = new Uri(this.env.BASE_URL())
                };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);


                var body = new DetectRequestBody
                {
                    url = imageUrlPath
                };
                var json = JsonConvert.SerializeObject(body);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("face/v1.0/detect?returnFaceId=true", data);

                var responseBody = response.Content.ReadAsStringAsync().Result;

                var l = JsonConvert.DeserializeObject<List<DetectResponseBody>>(responseBody);

                if(l.Count > 0)
                {
                    return l[0].faceId;
                } else
                {
                    return "0";
                }

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public async Task<VerifyResponseBody> Verify(string faceId1, string faceId2)
        {
            try
            {
                var client = new HttpClient();

                var key = this.env.OCP_APIM_KEY();
                var body = new VerifyRequestBody()
                {
                    FaceId1 = faceId1,
                    FaceId2 = faceId2

                };
                var json = JsonConvert.SerializeObject(body);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);

                var url = this.env.BASE_URL() + "/face/v1.0/verify";

                var response = await client.PostAsync(url, data);

                var responseBody = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<VerifyResponseBody>(responseBody);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public async Task<VerifyResponseBody> VerificationJob(string image1, string image2)
        {
            try
            {
                string faceId1 = await Detect(image1);
                string faceId2 = await Detect(image2);

                if(faceId1 != "0" || faceId2 != "0")
                {
                    return await Verify(faceId1, faceId2);
                } else
                {
                    return new VerifyResponseBody() { isIdentical = false, confidence = 0 };
                }

            } catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }
    }
}
