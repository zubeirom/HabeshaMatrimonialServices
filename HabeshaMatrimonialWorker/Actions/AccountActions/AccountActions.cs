using HabeshaMatrimonialStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialWorker.Actions.AccountActions
{
    public class AccountActions : IGetUnverifiedAccounts
    {

        IAccountRepository accountRepository;

        public AccountActions(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public List<Account> GetUnverifiedAccounts()
        {
            try
            {
                Console.WriteLine("====Fetching Unverified Accounts====");
                return this.accountRepository.GetUnverifiedAccounts();
            } catch(Exception e)
            {
                throw e;
            }
        }

        public void VerifyUnverifiedAccounts()
        {
            var accounts = this.GetUnverifiedAccounts();
            // 2. Foreach account call cognitive service
            foreach(var account in accounts)
            {
               // Cognitver service Interface for me to use
               // I will need a mock => return true if it's same => return false if not the same
               // Save result to the database
            }
        }
        
    }
}
