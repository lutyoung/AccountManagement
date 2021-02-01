using System;
using System.Collections.Generic;
using System.Text;

namespace AccountMangement
{
    class ManagerRepository
    {
        public List<Manager> Managers = new List<Manager>();


        public void Read(Manager manager)
        {
            Console.WriteLine($"{manager.GetId()} {manager.GetFirstName()} {manager.GetLastName()} {manager.GetMiddleName()}  {manager.GetEmail()}  {manager.GetPassword()}");
        }

        public void List()
        {
           // AccountHolderRepository accountHolderRepository = new AccountHolderRepository();

           // accountHolderRepository.CreateAccountHolder(0001, "Lutfulmannan", "Ghazal", "Oloruseun", new DateTime(2002, month: 03, day: 30), "ghazallutfulmannan@gmail.com", "09019640817", "ojokoro, lagos", "lutyoung14", "lutyoung12");

           // accountHolderRepository.CreateAccountHolder(0002, "Ade", "Aladu", "Oloruseun", new DateTime(2002, month: 03, day: 30), "adealadu17@gmail.com", "09019640817", "ojokoro, lagos", "lutypon14", "lutypon14");

           // accountHolderRepository.UpdateAccountHolder(0002, "Adeyemi", "Haladu", "halade18", "adealadu17@gmail.com");

            

            //accountHolderRepository.List();

            

            //foreach (Manager manager in Managers)
            //{
            //    Read(manager);
            //}
        }

       


        public void CreateManager(int id, string firstName, string lastName, string middleName,  string email, string password)
        {
            Manager manager = new Manager(id, firstName, lastName, middleName, email, password);
            Managers.Add(manager);
           
        }
                

        
        
    }
}
