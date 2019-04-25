using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInitializersLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CitiesContext())
            {
                //context.Cities.Add(new City { Name = "Бишкек", Population = 1311231 });
                //context.SaveChanges();
                foreach(var city in context.Cities.ToList())
                {
                    Console.WriteLine(city.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
