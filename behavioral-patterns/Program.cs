using behavioral_patterns;
using System;
namespace behavioral_patterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Shopping Cart Program!");

            decimal subtotal;
            while (true)
            {
                Console.Write("Enter subtotal: ");
                if (decimal.TryParse(Console.ReadLine(), out subtotal) && subtotal >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            Cart cart = new Cart(new NoDiscount());
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect a discount strategy:");
                Console.WriteLine("1) No Discount");
                Console.WriteLine("2) Percentage Discount");
                Console.WriteLine("3) Bank Cap Discount");
                Console.WriteLine("0) Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        cart.SetDiscountStrategy(new NoDiscount());
                        break;

                    case "2":
                        decimal percentage;
                        while (true)
                        {
                            Console.Write("Enter percentage (e.g., 10): ");
                            if (decimal.TryParse(Console.ReadLine(), out percentage) && percentage >= 0)
                                break;
                            Console.WriteLine("Invalid input. Please enter a valid positive number.");
                        }
                        cart.SetDiscountStrategy(new Percentage(percentage));
                        break;

                    case "3":
                        decimal discount;
                        while (true)
                        {
                            Console.Write("Enter discount amount: ");
                            if (decimal.TryParse(Console.ReadLine(), out discount) && discount >= 0)
                                break;
                            Console.WriteLine("Invalid input. Please enter a valid positive number.");
                        }

                        decimal maxCap;
                        while (true)
                        {
                            Console.Write("Enter maximum cap: ");
                            if (decimal.TryParse(Console.ReadLine(), out maxCap) && maxCap >= 0)
                                break;
                            Console.WriteLine("Invalid input. Please enter a valid positive number.");
                        }

                        cart.SetDiscountStrategy(new BankCapDiscount(discount, maxCap));
                        break;

                    case "0":
                        exit = true;
                        continue;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }

                decimal total = cart.Total(subtotal);
                Console.WriteLine($"Total with discount: {total:C}");
            }
        }
    }
}
