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
        new Restaurant { Name = "Pupen Seafood", Type = "Sea Food", Rating = 4.3},
        new Restaurant { Name = "Tandoori", Type = "Indian Cuisine", Rating = 4.8},
        new Restaurant { Name = "Suki Teenoi", Type = "Shabu", Rating = 4.8},
        new Restaurant { Name = "Isao", Type = "Japanese Fusion", Rating = 4.5},
        new Restaurant { Name = "Supanniga", Type = "Traditional Thai Cuisine", Rating = 4.4},
        new Restaurant { Name = "Greyhound", Type = "Modern Thai", Rating = 4.2}

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
            Console.Write("Enter Restaurant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Rating: ");
            double rating = Convert.ToDouble(Console.ReadLine());

            // เพิ่มข้อมูลร้านใหม่เข้าไปใน List
            restaurants.Add(new Restaurant
            {
                Name = name,
                Type = type,
                Rating = rating
            });

            Console.WriteLine("Restaurant added successfully!");
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
