using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public class UserAccountData
    {
        public string AccountHolderId { get; set; }
        public List<AccountData> Accounts { get; set; }

        public UserAccountData()
        {
            Accounts = new List<AccountData>();
        }
    }
}
