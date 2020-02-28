using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient.CognitveServices
{
    class Body<T>
    {
        T body;

        public Body(T body)
        {
            this.body = body;
        }
    }
}
