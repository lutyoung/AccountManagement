using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
   public class Account
    {
        private int Id;
        private string AccountNumber;
        private int AccountHolderId;
        private AccountHolder AccountHolder;
        private string PIN;
        private string AccountType;
        private DateTime DateOfCreation;
        private double AccountBalance;
        

        public Account( int id, string accountNumber, int accountHolderId, AccountHolder firstName, AccountHolder lastName, AccountHolder email, string pin, string accountType, DateTime dateOfCreation, double accountBalance)
        {
            this.Id = id;
            this.AccountNumber = accountNumber;
            this.AccountHolderId = accountHolderId;
            this.AccountHolder = firstName;
            this.AccountHolder = lastName;
            this.AccountHolder = email;
            this.PIN = pin;
            this.AccountType = accountType;
            this.DateOfCreation = dateOfCreation;
            this.AccountBalance = accountBalance;

        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }
        public void SetAccountNumber(string accountNumber)
        {
            this.AccountNumber = accountNumber;
        }

        public int GetAccountHolderId()
        {
            return AccountHolderId;
        }
        public void SetAccountHolderId(int accountHolderId)
        {
            this.AccountHolderId = accountHolderId;
        }

        public AccountHolder GetAccountHolder()
        {
            return AccountHolder;
        }
        public void SetAccountHolder(AccountHolder accountHolder)
        {
            this.AccountHolder = accountHolder;
        }

        public string GetAccountType()
        {
            return AccountType;
        }
        public void SetAccountType(string accountType)
        {
            this.AccountType = accountType;
        }
        
        public string GetPIN()
        {
            return PIN;
        }
        public void SetPIN(string pin)
        {
            this.PIN = pin;
        }

        public DateTime GetDateOfCreation()
        {
            return DateOfCreation;
        }
        public void SetDateOfCreation(DateTime dateOfCreation)
        {
            this.DateOfCreation = dateOfCreation;
        }

        public double GetAccountBalance()
        {
            return AccountBalance;
        }
        public void SetAccountBalance(double accountBalance)
        {
            this.AccountBalance = accountBalance;
        }
    }
}
