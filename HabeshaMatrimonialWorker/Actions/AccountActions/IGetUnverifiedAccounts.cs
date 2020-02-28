using HabeshaMatrimonialStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialWorker.Actions.AccountActions
{
    public interface IGetUnverifiedAccounts
    {
         List<Account> GetUnverifiedAccounts();
    }
}
