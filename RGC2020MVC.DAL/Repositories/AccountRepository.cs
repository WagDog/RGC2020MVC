using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGC2020MVC.DAL.Data;
using RGC2020MVC.Model;

namespace RGC2020MVC.DAL.Repositories
{
    public class AccountRepository : RepositoryBase<Account>
    {
        public AccountRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
