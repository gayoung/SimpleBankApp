using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public enum AccountType
    {
        Debit,
        Loan,
    }

    public class AccountData
    {
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double CurrentBalance { get; set; }
        public string CurrencyUnit { get; set; }
    }

    public class DebitAccountData: AccountData
    {
        public double AvailableBalance { get; set; }
    }

    public class CreditAccountData : AccountData
    {
        public double TotalLimit { get; set; }
    }
}
