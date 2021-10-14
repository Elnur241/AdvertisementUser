using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class User
    {
        public User()
        {

        }
        public User(string name,string surName,int age)
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
        }
        private string name;
        private string surName;
        private int age;
        public string Name { get { return this.name; }
            set { this.name = value; } }
        public string SurName { get { return this.surName; }
            set { this.surName = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
    }
}
