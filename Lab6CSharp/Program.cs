using System;
using pro100user.task2;
using pro100user.task3;

namespace fanatic 
{
    /*
     * Лабараторна робота №6
     * Скуратовського Вадима група 341ск
     * Варіант 19
     */
    public class Lab6
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Завдання 1");
                Console.WriteLine("2. Завдання 2");
                Console.WriteLine("3. Вихід");
                Console.Write("Введіть вибране число: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == 3)
                    {
                        Console.WriteLine("Вихід...");
                        return;
                    }

                    switch (number)
                    {
                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        default:
                            Console.WriteLine("Ви ввели не те число. Повторіть спробу");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nВи не правильно ввели число. Повторіть спробу");
                }
                Console.WriteLine();
            }
        }
        
        static void Task1()
        {
            List<Product> products = new List<Product>()
            {
                new ProductImpl(),
                new DetailImpl(),
                new MechanismImpl(),
                new NodeImpl()
            };
            products.ForEach(product => product.Show()); 
        }
        
        static void Task2()
        {
            List<Client> clients = new List<Client>()
            {
                new Creditor("Creditor", 500, 10, 550),
                new Investor("Investor", 10000, 10),
                new Organization("Organization", "UA1234567890", 100000)
            };
            clients.ForEach(client => client.Print()); 
        }
    }
}
