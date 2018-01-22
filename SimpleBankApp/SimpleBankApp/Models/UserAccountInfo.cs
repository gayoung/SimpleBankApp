using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockRepository;

namespace SimpleBankApp.Models
{
    public enum AccountType
    {
        Debit,
        Loan,
    }

    public class UserAccountInfo
    {
        public string AccountHolderId { get; set; }
        public Dictionary<AccountType,List<AccountInfo>> Accounts { get; set; }

        public UserAccountInfo(UserAccountData data)
        {
            AccountHolderId = data.AccountHolderId;
            Accounts = new Dictionary<AccountType, List<AccountInfo>>
            {
                { AccountType.Debit, new List<AccountInfo>() },
                { AccountType.Loan, new List<AccountInfo>() }
            };

            foreach (var account in data.Accounts)
            {
                if (account.GetType() == typeof(CreditAccountData))
                    Accounts[AccountType.Loan].Add(new CreditAccountInfo(account as CreditAccountData));

                else if (account.GetType() == typeof(DebitAccountData))
                    Accounts[AccountType.Debit].Add(new DebitAccountInfo(account as DebitAccountData));
            }
        }
    }
}