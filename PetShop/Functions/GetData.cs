using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Functions
{
    static class GetData
    {
        static void GetAllAnimals()
        {
            using (var context = new PetShopContext())
            {
                var animal = context.Animals.Include(a => a.Supplier).ToList();
                foreach (var item in animal)
                {
                    var supplierName = item.Supplier.Name;
                    Console.WriteLine($"Animal: {item.Name}, Location: {supplierName} ");
                }
            }
        }

    }
}
