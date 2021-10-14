using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Advertisement advertisement = new Advertisement("Network", "Fuad", 80);
            Advertisement.Category category = Advertisement.Category.Native;

            Advertisement advertisement2 = new Advertisement("Snickers", "Eli", 70);
            Advertisement advertisement3 = new Advertisement("Snickers", "Eli",60);
            Advertisement advertisement4 = new Advertisement("Snickers", "Eli",200);
            Advertisement[] advertisements = { advertisement4,advertisement, advertisement2, advertisement3 };
           
            int sum=advertisements.Sum();
            Console.WriteLine(sum);
            Console.WriteLine(category);

            Console.WriteLine(advertisement2< advertisement);
                
            advertisements.Sort();
            foreach (var item in advertisements)
            {
                Console.WriteLine(item.Price);
            }
            Console.ReadKey();
         
        }
     
    }

}
