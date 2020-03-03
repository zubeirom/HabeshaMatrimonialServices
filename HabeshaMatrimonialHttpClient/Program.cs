using HabeshaMatrimonialHttpClient.CognitveServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialHttpClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Environment env = new Environment();
            AzureCognitiveService acs = new AzureCognitiveService(env);
            string zubeir1 = "https://imgur.com/9Mc3IiI.png";
            string zubeir2 = "https://imgur.com/6qdXap7.png";

            string logo1 = "https://imgur.com/eNgyowS.png";
            string human2 = "https://imgur.com/UH9wGb0.png";

            string obama = "https://www.biography.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cg_face%2Cq_auto:good%2Cw_300/MTE4MDAzNDEwNzg5ODI4MTEw/barack-obama-12782369-1-402.jpg";
            string obamaLookAlike = "https://media1.s-nbcnews.com/j/newscms/2016_02/1374066/160112-obama-1101p_1d16238ca868f5d9b1eb70c950d8f03f.fit-2000w.jpg";

            string jayz = "https://cdn.mdr.de/kultur/radio/jay_z-104-resimage_v-variantSmall24x9_w-640.jpg";
            string jayzLookAlike = "https://i.dailymail.co.uk/i/pix/2017/01/24/10/3C73EA7000000578-4150850-Jay_Z_s_lookalike_isslightly_more_unusual_in_that_she_is_a_diffe-a-134_1485253392682.jpg";

            string cooperNoBeard = "https://cdn.britannica.com/57/199057-050-CCE5410A/Bradley-Cooper-2008.jpg";
            string cooperBeard = "https://the-hollywood-gossip-res.cloudinary.com/iu/s--cIJxm5xl--/t_full/cs_srgb,f_auto,fl_strip_profile.lossy,q_auto:420/v1491817953/bradley-cooper-and-his-beard.jpg";

            string jonahHill = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Jonah_Hill-4939_%28cropped%29.jpg/1200px-Jonah_Hill-4939_%28cropped%29.jpg";
            string jonahHillOld = "https://m.media-amazon.com/images/M/MV5BMTUyNDU0NzAwNl5BMl5BanBnXkFtZTcwMzQxMzIzNw@@._V1_.jpg";

            var res1 = await acs.VerificationJob(zubeir1, zubeir2);
            var res2 = await acs.VerificationJob(logo1, human2);
            var res3 = await acs.VerificationJob(obama, obamaLookAlike);
            var res4 = await acs.VerificationJob(cooperNoBeard, cooperBeard);
            var res5 = await acs.VerificationJob(jonahHill, jonahHillOld);
            var res6 = await acs.VerificationJob(jayz, jayzLookAlike);

            Console.WriteLine("Is identical: " + res1.isIdentical + " confidence: " + res1.confidence);
            Console.WriteLine("Is identical: " + res2.isIdentical + " confidence: " + res2.confidence);
            Console.WriteLine("Is identical: " + res3.isIdentical + " confidence: " + res3.confidence);
            Console.WriteLine("Is identical: " + res4.isIdentical + " confidence: " + res4.confidence);
            Console.WriteLine("Is identical: " + res5.isIdentical + " confidence: " + res5.confidence);
            Console.WriteLine("Is identical: " + res6.isIdentical + " confidence: " + res6.confidence);

        }
    }
}
