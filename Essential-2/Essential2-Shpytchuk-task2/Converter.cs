

using System;

namespace Essential2_Shpytchuk_task2
{
    class Converter
    {
        public decimal Usd { get; set; }
        public decimal Eur { get; set; }
        public decimal Rub { get; set; }

        public Converter (decimal usd, decimal eur, decimal rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
        public decimal ConvertFromHryvnya(decimal amount, string currency)
        {
            switch (currency)
            {
                case "usd": 
                    return Math.Round(amount * Usd,2);
                case "eur": 
                    return Math.Round(amount * Eur);
                case "rub":
                    return Math.Round(amount * Rub);
                default:
                    Console.WriteLine("Неправильно введена валюта");
                    return 0;

            }
        }
        public decimal ConvertToHryvnya(decimal amount, string currency)
        {
            switch (currency)
            {
                case "usd":
                    return Math.Round(amount / Usd);
                case "eur":
                    return Math.Round(amount / Eur);
                case "rub":
                    return Math.Round(amount / Rub);
                default:
                    Console.WriteLine("Неправильно введена валюта");
                    return 0;
            }
        }

    }
}
