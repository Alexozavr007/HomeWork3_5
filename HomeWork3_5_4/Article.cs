using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_5_4
{
    internal class Article
    {
        private string ArticleName { get; set; }
        private string ShopName { get; set; }
        private int Price { get; set; }

        public Article (string articleName, string shopName, int price)
        {
            ArticleName = articleName;
            ShopName = shopName;
            Price = price;
        }

        public bool IsEqual(string articleName) {
            return this.ArticleName == articleName;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Товар: {ArticleName}");
            Console.WriteLine($"Магазин: {ShopName}");
            Console.WriteLine($"Вартість: {Price}");
        }

    }

}
