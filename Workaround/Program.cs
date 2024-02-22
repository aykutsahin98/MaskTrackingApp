using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Aykut";
            person1.LastName = "Şahin";
            person1.NationalIdentity = 36585263252;
            person1.DateOfBirth = 1998;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }
    }
}
