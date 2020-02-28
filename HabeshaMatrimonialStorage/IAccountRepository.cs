using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialStorage
{
    public interface IAccountRepository: IGenericRepository<Account>
    {
        List<Account> GetUnverifiedAccounts();

    }
}
