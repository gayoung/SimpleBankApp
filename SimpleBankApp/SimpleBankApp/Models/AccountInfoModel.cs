using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MockRepository;

namespace SimpleBankApp.Models
{
    public class AccountInfo
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        [DataType(DataType.Currency)]
        public double CurrentBalance { get; set; }
       
        public string CurrencyUnit { get; set; }
    }

    public class DebitAccountInfo : AccountInfo
    {
        [DataType(DataType.Currency)]
        public double AvailableBalance { get; set; }

        public DebitAccountInfo(DebitAccountData data)
        {
            AccountNumber = data.AccountNumber;
            AccountName = data.AccountName;
            CurrentBalance = data.CurrentBalance;
            CurrencyUnit = data.CurrencyUnit;
            AvailableBalance = data.AvailableBalance;
        }
    }

    public class CreditAccountInfo : AccountInfo
    {
        [DataType(DataType.Currency)]
        public double TotalLimit { get; set; }

        public CreditAccountInfo(CreditAccountData data)
        {
            AccountNumber = data.AccountNumber;
            AccountName = data.AccountName;
            CurrentBalance = data.CurrentBalance;
            CurrencyUnit = data.CurrencyUnit;
            TotalLimit = data.TotalLimit;
        }
    }
}