using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team_17_31_43
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "KFC", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 }
       
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.WriteLine("Not completed");
        }

        // คน B รับผิดชอ
            static void ShowGoodRating()
            {
                Console.WriteLine("\n===== Good Rating Restaurants =====");

                foreach (var restaurant in restaurants)
                {
                    if (restaurant.Rating >= 4.5)
                    {
                        Console.WriteLine($"Name: {restaurant.Name}");
                        Console.WriteLine($"Type: {restaurant.Type}");
                        Console.WriteLine($"Rating: {restaurant.Rating}");
                        Console.WriteLine("--------------------------");
                    }
                }
            }
        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("\n===== Show Summary =====");

            Restaurant highest = restaurants.OrderByDescending(r => r.Rating).First();
            Restaurant lowest = restaurants.OrderBy(r => r.Rating).First();

            Console.WriteLine("\nร้านที่มีคะแนนสูงสุด");
            Console.WriteLine($"Name: {highest.Name}");
            Console.WriteLine($"Type: {highest.Type}");
            Console.WriteLine($"Rating: {highest.Rating}");

            Console.WriteLine("\nร้านที่มีคะแนนต่ำสุด");
            Console.WriteLine($"Name: {lowest.Name}");
            Console.WriteLine($"Type: {lowest.Type}");
            Console.WriteLine($"Rating: {lowest.Rating}");
        }
    }

}
