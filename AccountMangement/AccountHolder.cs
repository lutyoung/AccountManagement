using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
    public class AccountHolder
    {

        public int Id;
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public DateTime DateOfBirth;
        public string Email;
        public string PhoneNumber;
        public string Address;
        public string Password;

        public AccountHolder(int id, string firstName, string lastName, string middleName, DateTime dateOfBirth, string email, string phoneNumber, string address, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Password = password;

        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }

        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public string GetMiddleName()
        {
            return MiddleName;
        }
        public void SetMiddleName(string middleName)
        {
            this.MiddleName = middleName;
        }

        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            this.Address = address;
        }

        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
    }
}
