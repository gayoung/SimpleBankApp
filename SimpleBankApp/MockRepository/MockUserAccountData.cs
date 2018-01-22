using System;
using System.Collections.Generic;
using System.Text;

namespace MockRepository
{
    // This class is representing the repository layer that would normally exist 
    // if the application is linked to a database.  The repository classes
    // will typically have methods to retrieve data and perform CRUD functionalities.
    // In this case, the method is used to return mocked up data to be displayed on the web application.
    public static class MockUserAccountData
    {
        public static UserAccountData GetMockUserAccountData(string userId)
        {
            var mockedData = new UserAccountData();
            mockedData.AccountHolderId = userId;
            switch (userId)
            {
                case "Katherine":
                    mockedData.Accounts.Add(new DebitAccountData
                    {
                        AccountName = "Unlimited Account",
                        AccountNumber = "154365",
                        AccountType = AccountType.Debit,
                        AvailableBalance = 1234.23,
                        CurrentBalance = 2045.43,
                        CurrencyUnit = "en-ca"

                    });

                    mockedData.Accounts.Add(new DebitAccountData
                    {
                        AccountName = "US Dollar Chequing Account",
                        AccountNumber = "965765",
                        AccountType = AccountType.Debit,
                        AvailableBalance = 2267.34,
                        CurrentBalance = 3425.97,
                        CurrencyUnit = "en-us"

                    });
                    break;

                case "Washington":
                    mockedData.Accounts.Add(new DebitAccountData
                    {
                        AccountName = "Basic Account",
                        AccountNumber = "456789",
                        AccountType = AccountType.Debit,
                        AvailableBalance = 526.31,
                        CurrentBalance = 526.31,
                        CurrencyUnit = "en-ca"

                    });

                    mockedData.Accounts.Add(new DebitAccountData
                    {
                        AccountName = "Tax Free Savings Account",
                        AccountNumber = "781240",
                        AccountType = AccountType.Debit,
                        AvailableBalance = 15742.58,
                        CurrentBalance = 15742.58,
                        CurrencyUnit = "en-ca"

                    });

                    mockedData.Accounts.Add(new CreditAccountData
                    {
                        AccountName = "Alberta Mastercard",
                        AccountNumber = "5191 6843 4598 1254",
                        AccountType = AccountType.Loan,
                        TotalLimit = 2000.00,
                        CurrentBalance = 424.65,
                        CurrencyUnit = "en-ca"

                    });
                    break;

                case "Maximilian":
                    mockedData.Accounts.Add(new CreditAccountData
                    {
                        AccountName = "Elite Travel Mastercard",
                        AccountNumber = "5191 6843 4598 1254",
                        AccountType = AccountType.Loan,
                        TotalLimit = 6000.00,
                        CurrentBalance = 23.02,
                        CurrencyUnit = "en-ca"

                    });
                    break;
            }

            return mockedData;
        }
    }
}
