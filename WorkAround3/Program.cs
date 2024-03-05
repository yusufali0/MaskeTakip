using Business.Concrete;
using Entities.Concrete;

namespace WorkAround3
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 =new Person();
            person1.FirstName = "Yusuf Ali";
            person1.LastName = "Bekçi";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }
    }
}
