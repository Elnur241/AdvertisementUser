using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   static class Extension
    {
        public static int Sum(this Advertisement[] arr)
        {
            int sum = 0;
            foreach (Advertisement item in arr)
            {
                sum += item.Price;

            }
            return sum;
        }

        public static void Sort(this Advertisement[] arr)
        {
        
            for (int i = 0; i <=arr.Length-1; i++)
            {
                for (int j = 0; j <= arr.Length-1; j++)
                {
                    if (arr[i].Price <= arr[j].Price)
                    {
                        int y = arr[i].Price;
                        arr[i].Price = arr[j].Price;
                        arr[j].Price = y;
                    }
                    //else
                    //{
                    //    arr[i].Price = arr[i].Price;
                    //}
                    
                }              
            }
        }
    }
}
