using laba2.Accounts.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.DB.Entity
{
    public class AccountEntity
    {
        public string Name { get; set; }

        public AccountType Type { get; set; }

        public int Rating { get; set; }

    }
}
