using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialStorage
{
    public class Account
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public bool verified { get; set; }
        public string profileImagePath { get; set; }
        public string profileImageVerifierPath { get; set; }

        public Account(int id, string firstName, string lastName, string email, bool verified, string profileImagePath, string profileImageVerifierPath)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.verified = verified;
            this.profileImagePath = profileImagePath;
            this.profileImageVerifierPath = profileImageVerifierPath;
        }

    }
}
