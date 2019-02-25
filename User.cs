using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class User
    {
        public int Age;
        public string Name;
        public string Bio;
        public User()
        {
            
        }
        public User(string name, string bio, int age)
        {
            Name = name;
            Bio = bio;
            Age = age;
        }

        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public User(int age)
        {
            Age = age;
        }

        public void GetInfo()
        {   
            Console.WriteLine($"{Name} {Age} {Bio}");
        }

    }
}
