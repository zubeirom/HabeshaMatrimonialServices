using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient.CognitveServices
{
    class VerifyResponseBody
    {
        public bool isIdentical { get; set; }
        public float confidence { get; set; }
    }
}
