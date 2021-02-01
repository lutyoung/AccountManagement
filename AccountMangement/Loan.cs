using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
    class Loan
    {
        private int Id;
        private int AccountId;
        private Account Account;
        private string Status;
        private string LoanType;
        private DateTime Date;
        private double Amount;


        public Loan( int id, int accountId,Account account, string status, string loanType, DateTime date, double amount)
        {
            this.Id = id;
            this.AccountId = accountId;
            this.Account = account;
            this.Status = status;
            this.LoanType = loanType;
            this.Date = date;
            this.Amount = amount;
        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }

        public int GetAccountId()
        {
            return AccountId;
        } 
        public void SetAccountId(int accountId)
        {
            this.AccountId = accountId;
        }

        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            this.Status = status;
        }

        public string GetLoanType()
        {
            return LoanType;
        }
        public void SetLoanType(string loanType)
        {
            this.LoanType = loanType;
        }

        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            this.Date = date;
        }

        public double GetAmount()
        {
            return Amount;
        }
        public void SetAmount(double amount)
        {
            this.Amount = amount;
        }
    }
}
