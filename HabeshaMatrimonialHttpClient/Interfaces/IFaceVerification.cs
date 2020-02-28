using HabeshaMatrimonialHttpClient.CognitveServices;
using HabeshaMatrimonialStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient
{
    interface IFaceVerification
    {
        Task<String> Detect(string imageUrlPath);

        Task<VerifyResponseBody> Verify(string faceId1, string faceId2);

        Task<VerifyResponseBody> VerificationJob(string image1, string image2);

    }
}
