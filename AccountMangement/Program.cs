using System;

namespace AccountMangement
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AccountHolderRepository accountHolderRepository = new AccountHolderRepository();

            try
            {

                Console.WriteLine("Enter Your ID:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Your Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Your Middle Name:");
                string middleName = Console.ReadLine();

                Console.WriteLine("Enter Your Date Of Birth:");
                DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter Your Email Address");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your Phone Number:");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Your Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter Your Password:");
                string password = Console.ReadLine();

                Console.WriteLine("Confirm Your Password");
                string checkPassword = Console.ReadLine();

                accountHolderRepository.CreateAccountHolder(id, firstName, lastName, middleName, dateOfBirth, email, phoneNumber, address, password, checkPassword);

                accountHolderRepository.List();

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            

        }
    }
}
