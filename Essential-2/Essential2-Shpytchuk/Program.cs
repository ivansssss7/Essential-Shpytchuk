
using Essential2_Shpytchuk;

namespace essential_2
{
    class Program
    {
        static void Main()
        {
            User user1 = new User("Ivan_Shpytchuk", "Ivan", "Shpytchuk",22);

            Console.WriteLine("Login: "+user1.Login);
            Console.WriteLine("Name: "+user1.Name);
            Console.WriteLine("Surname: "+user1.Surname);
            Console.WriteLine("Age: "+user1.Age);
            Console.WriteLine("Date: "+user1.DateWriteQuestionnaire);
        }
    }
}
