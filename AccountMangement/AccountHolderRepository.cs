using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
    class AccountHolderRepository
    {
        public List<AccountHolder> AccountHolders = new List<AccountHolder>();


        public void Read(AccountHolder accountHolder)
        {
            Console.WriteLine($"{accountHolder.GetId()} {accountHolder.GetFirstName()} {accountHolder.GetLastName()} {accountHolder.GetMiddleName()} {accountHolder.GetDateOfBirth()} {accountHolder.GetEmail()} {accountHolder.GetAddress()} {accountHolder.GetPhoneNumber()} {accountHolder.GetPassword()}");
        }

        public void List()
        {
            foreach (AccountHolder accountHolder in AccountHolders)
            {
                Read(accountHolder);
            }
        }

        public void CreateAccountHolder(int id, string firstName, string lastName, string middleName, DateTime dateOfBirth, string email, string phoneNumber, string address, string password, string checkPassword)
        {
            try
            {

                AccountHolder accountHolder = new AccountHolder(id, firstName, lastName, middleName, dateOfBirth, email, phoneNumber, address, password);

                if (password == checkPassword)
                {
                    var a = FindByIdOrEmail(id, email);

                    if (a == null)
                    {
                        AccountHolders.Add(accountHolder);
                    }
                    else
                    {
                        //Console.WriteLine($"This {id} and {email} already exist");
                        throw new Exception($"User already exist");
                    }
                }
                else
                {
                    //Console.WriteLine("Password mismatch");
                    throw new Exception($"Password Mismatch!");

                }
            } catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }


        }


        public AccountHolder FindByIdOrEmail(int id, string email)
        {
            return AccountHolders.Find(a => a.Id == id || a.Email == email);
        }

        public void UpdateAccountHolder(int id, string firstName, string lastName, string password, string email)
        {
            var update = FindByIdOrEmail(id, email);
            update.FirstName = firstName;
            update.LastName = lastName;
            update.Password = password;
        }
        public void RemoveAccountHolder(int id, string email)
        {
            AccountHolders.Remove(FindByIdOrEmail(id, email));
        }


    }
}
