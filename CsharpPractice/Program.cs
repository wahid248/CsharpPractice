using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = GetCars();
            var customers = GetCustomers();
            var customerToCar = GetCustomerToCarMapping();

            var ownedCars = cars.Where(c => customerToCar.Values.Contains(c.Key)).ToList();

            foreach(var car in ownedCars)
            {
                Console.WriteLine(car.Value);
            }
        }

        public static Dictionary<int, string> GetCustomers()
        {
            return new Dictionary<int, string>
            {
                { 1, "Jack" },
                { 2, "Daniel" },
                { 3, "Max" },
                { 4, "Howard" },
                { 5, "Stark" }
            };
        }

        public static Dictionary<int, string> GetCars()
        {
            return new Dictionary<int, string>
            {
                { 1, "Marcedes" },
                { 2, "Toyota" },
                { 3, "Vox Wagon" },
                { 4, "Tesla" },
                { 5, "Corvette" }
            };
        }

        public static Dictionary<int, int> GetCustomerToCarMapping()
        {
            return new Dictionary<int, int>
            {
                { 1, 2 },
                { 4, 3 },
                { 5, 4 }
            };
        }
    }
}
