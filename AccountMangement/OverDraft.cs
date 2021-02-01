using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
    class OverDraft
    {
        private int Id;
        private double Amount;
        private int AccountId;
       // private Account Account;
        private DateTime Date;


        public OverDraft( int id, int accountId, double amount, DateTime date)
        {
            this.Id = id;
            this.Amount = amount;
            this.AccountId = accountId;
            this.Date = date;
            
        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }

        public double GetAmount()
        {
            return Amount;
        }
        public void SetAmount(double amount)
        {
            this.Amount = amount;
        }

        public int GetAccountId()
        {
            return AccountId;
        }
        public void SetAccountId( int accountId)
        {
            this.AccountId = accountId;
        }

        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            this.Date = date;
        }
    }
}
