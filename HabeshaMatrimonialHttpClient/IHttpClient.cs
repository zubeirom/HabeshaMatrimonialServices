using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient
{
    interface IHttpClient
    {
        void Get();

        void Post();

        void Delete();

        void Patch();

        void Put();
    }
}
