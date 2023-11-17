

using System.Text;

namespace essential_1_4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Adress adress = new Adress();   
            adress.Index = 01001;
            adress.City = "Kyiv";
            adress.Street = "Khreshchatyk";
            adress.Home = "44а";
            adress.Apartment = "31";
            Console.WriteLine("інформація про поштову адресу");
            Console.WriteLine($"індекс - {adress.Index}, місто - {adress.City}, вулиця - {adress.Street}, " +
                              $"будинок - {adress.Home}, квартира - {adress.Apartment}");
        }
    }
}
