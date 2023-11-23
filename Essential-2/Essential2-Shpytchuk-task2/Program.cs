


namespace Essential2_Shpytchuk_task2
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(36.06M,39.33M,22.4M);

            Console.WriteLine("Курси валют");
            Console.WriteLine($"Долар - {converter.Usd}, Євро - {converter.Eur}, Рубль - {converter.Rub}");

            Console.WriteLine("Переведення з гривень у валюту - 1");
            Console.WriteLine("Переведення з валюти в гривню - 2");
            Console.WriteLine("Яку операцію бажаєте виконати?");
            int choise = int.Parse(Console.ReadLine());

            Console.Write("Введіть суму для конвертації ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введіть валюту для конвертації usd, eur, rub - ");
            string currency = Console.ReadLine();

            switch (choise) 
            {
                case 1:
                    Console.WriteLine(converter.ConvertFromHryvnya(amount, currency));
                    break;
                case 2:
                    Console.WriteLine(converter.ConvertToHryvnya(amount, currency));
                    break;
            }
        }
    }
}
