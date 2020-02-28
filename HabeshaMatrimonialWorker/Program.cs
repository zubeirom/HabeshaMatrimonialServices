using HabeshaMatrimonialWorker.Actions.AccountActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountRepositoryMock accountRepositoryMock = new AccountRepositoryMock();
            AccountActions accountAction = new AccountActions(accountRepositoryMock);
            Worker worker = new Worker();
            worker.ActivateWorker(() => accountAction.VerifyUnverifiedAccounts(), 5000);
        }
    }
}
