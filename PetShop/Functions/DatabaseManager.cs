using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Functions
{
    public static class DatabaseManager
    {
        public static void Add<T>(T entity, PetShopContext context) where T : class
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public static void Remove<T>(T entity, PetShopContext context) where T : class
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public static void Get<T>(T entity, PetShopContext context) where T : class
        {

        }
    }
}
