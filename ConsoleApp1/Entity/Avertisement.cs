using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Advertisement
    {
        private string name;
        private int price;
        private string vendorName;
        public Advertisement()
        {

        }
        public Advertisement(string name,string vendorName,int price)
        {
            this.name = name;
            this.vendorName = vendorName;
            this.price = price;
        }
       
       public enum  Category
        {
            Paidsearch ,
            Socialmedia ,
            Native,
            Display,
            Print,
            Broadcast,
            Outdoor
        }
        public string Name {
            get 
            {
                return this.name;
            } 
            set 
            {

                this.name = value;
            } }
        public int Price {
            get { return this.price; }
            set { this.price = value; } }

        public string VendorName
        {
            get { return this.vendorName; }
            set { this.vendorName = value; }
        }
    
        public static bool operator<(Advertisement advertisement, Advertisement advertisement2)
        {
            return advertisement.price<advertisement2.price;
        }
        public static bool operator>(Advertisement advertisement, Advertisement advertisement2)
        {
            return advertisement.price > advertisement2.price;
        }
    }
}