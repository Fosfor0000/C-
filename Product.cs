using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab1C_
{
    public class Product
    {
        private string Name {  get;  set; }
        private double Price { get;  set; }
        private int Quantity { get;  set; }
        public double TotalValue => Price * Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product()
        {

        }
        public void Restock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Кількість для поповнення не може бути від'ємною.");
            }

            Quantity += amount;
        }
        public void Sell(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Кількість для продажу не може бути від'ємною.");
            }
            if (amount > Quantity)
            {
                throw new InvalidOperationException($"Недостатньо товару {Name} на складі. Доступно: {Quantity}.");
            }
            Quantity -= amount;
        }
        public (string Name, double Price, int Quantity, double TotalValue) GetInfo()
        {
            return (Name, Price, Quantity, TotalValue);
        }
        public override string ToString()
        {
            return $"Товар: {Name}, Ціна: {Price}, Кількість: {Quantity}, Загальна вартість: {TotalValue}";
        }
    }


}
