using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
    class AccountRepository
    {
        public List<Account> Accounts = new List<Account>();
        public void Read(Account account)
        {
            Console.WriteLine($"{account.GetId()} {account.GetAccountNumber()} {account.GetAccountHolderId()} {account.GetAccountHolder().FirstName} {account.GetAccountHolder().LastName} {account.GetAccountHolder().Email} {account.GetPIN()} {account.GetAccountType()} {account.GetDateOfCreation()} {account.GetAccountBalance()}");
        }

        public void List()
        {
            foreach (Account account in Accounts)
            {
                Read(account);
            }
        }
        
        public void CreateAccount(int id, string accountNumber, int accountHolderId, AccountHolder firstName, AccountHolder lastName, AccountHolder email, string pin, string accountType, DateTime dateOfCreation, double accountBalance)
        {
            Account account = new Account(id, accountNumber, accountHolderId, firstName, lastName, email, pin, accountType, dateOfCreation, accountBalance);

            Accounts.Add(account);
        }

    }
}
