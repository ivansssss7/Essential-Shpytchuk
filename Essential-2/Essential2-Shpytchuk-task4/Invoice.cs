using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essential_2_task4
{
    class Invoice
    {
        private readonly int account;
        private readonly string costumer;
        private readonly string provider;

        private int Quantity { get; set; }
        private string Article { get; set; } = null;

        public Invoice(int account, string costumer, string provider)
        {
            this.account = account;
            this.costumer = costumer;
            this.provider = provider;
        }
        //вирішив створити окремий метод для встановлення інформації про товар у класі
        //була ідея розширити конструктор, але вважав що так зручніше і зрозуміліше
        public void SetArticle(string article, int quantity)
        {
            Quantity = quantity;
            Article = article;
        }
        public double CalculateCost(bool includeVAT)
        {
            double cost = GetCostWithoutVAT();
            if (includeVAT)
            {
                //нехай пдв буде 20%
                cost *= 1.2; 
            }
            return cost;
        }

        private double GetCostWithoutVAT()
        {
            //нехай  ціна буде 300
            return 300 * Quantity; 
        }
    }
}
