

namespace essential_2_task4
{
    class Program
    {
        static void Main()
        {
            // Створюємо замовленя
            Invoice invoice = new Invoice(12345, "Ivan", "Serhii");

            // Визначаємо товар і кількість 
            invoice.SetArticle("Book", 5);

            // Ціна з пдв
            double costWithVAT = invoice.CalculateCost(true);
            Console.WriteLine($"Ціна з пдв: {costWithVAT}");

            // Ціна без пдв
            double costWithoutVAT = invoice.CalculateCost(false);
            Console.WriteLine($"Ціна без пдв: {costWithoutVAT}");
        }
    }
}
