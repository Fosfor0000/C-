

namespace lab1C_
{
    internal class Programm
    {
        static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

           

            Product product1 = new Product("Laptop", 1000.0, 5);
            Product product2 = new Product("Mouse", 25.0, 2);
            Product product3 = new Product("Keyboard", 50.0, 10);

            Console.WriteLine("Початковий стан:");
            

            product1.Restock(3);
            Console.WriteLine("\nПісля поповнення Laptop на 3 одиниці:");
            Console.WriteLine(product1.);
            

            product2.Sell(1);
            Console.WriteLine("\nПісля продажу 1 Mouse:");
            Console.WriteLine(product2);
           

            try
            {
                product2.Sell(2); 
                Console.WriteLine("\nПісля продажу 2 Mouse:");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Помилка: {e.Message}");
            }
        }
    }
}