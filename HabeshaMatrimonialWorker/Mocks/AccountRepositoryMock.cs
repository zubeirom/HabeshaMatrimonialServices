using HabeshaMatrimonialStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialWorker
{
    class AccountRepositoryMock : IAccountRepository
    {
        List<Account> Accounts = new List<Account>
        {
            new Account(1, "Zubeir", "Mohamed", "zubeir@mail.com", false, "https://imgur.com/img.png", "https://imgur.com/img2.png"),
            new Account(2, "Jemal", "Abdulkadir", "jemex@mail.com", false, "https://imgur.com/img.png", "https://imgur.com/img2.png"),
            new Account(3, "Suleiman", "Abdulkadir", "sulum@mail.com", false, "https://imgur.com/img.png", "https://imgur.com/img2.png"),
            new Account(4, "Wail", "Mohamed", "wail@mail.com", true, "https://imgur.com/img.png", "https://imgur.com/img2.png"),
            new Account(5, "Hamza", "Mohamed", "hamza@mail.com", true, "https://imgur.com/img.png", "https://imgur.com/img2.png")
        };

        public void Delete(int id)
        {

        }

        public List<Account> GetAll()
        {
            return this.Accounts;
        }

        public Account GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetUnverifiedAccounts()
        {
            return this.Accounts.Where(account => !account.verified).ToList();
        }

        public Account Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
