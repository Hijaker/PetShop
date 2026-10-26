using Microsoft.EntityFrameworkCore;
using PetShop.Functions;
using PetShop.Models;

namespace PetShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var context = new PetShopContext())
            {
                var supplier = context.Suppliers.SingleOrDefault(s => s.SupplierID == 10);
                // Create and add an animal with the created supplier
                var animal = new Animals
                {
                    Name = "Buddy",
                    Species = "Dog",
                    Age = 3,
                    Price = 150.00M,
                    Supplier = supplier // associate existing supplier
                };
                DatabaseManager.Add(animal, context);
            }
        }
    }
}
