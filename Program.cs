using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        { 
            int age;
            string name;
            string bio;
            List<User> users =  new List<User>();
            var user = new User();
            int n=Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<n;i++)
            { 
                age = Convert.ToInt32(Console.ReadLine());
                name = Console.ReadLine();
                bio = Console.ReadLine();
                if (bio == ".end")
                {
                    bio = null;
                    users.Add(new User(name, bio, age));
                    break;
                }
                users.Add(new User(name, bio, age));
            }
            users.OrderBy(e => e.Age);
            foreach(var u in users)
            {
                u.GetInfo();
            }
            
            Console.ReadKey();

        }
    }
}
