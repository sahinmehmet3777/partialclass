using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass
{
    // Class'a ek yapmak istediğimiz zaman başına partial koyuyoruz, ve class'ın aynısını yazıp sadece eklenicek şeyi içerisine yaz
    // aynı isimli bu iki class birleşiyot
    // partial kelimesiyle class kapatılmaz, ileride ek kodlar ekleyebilmemizi sağlar
    public partial class User
    {
        private string name;
        private string location;
        public User(string a, string b)
        {
            this.name = a;
            this.location = b;
        }
    }

    public partial class User
    {
        public void GetUserDetails()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("location: " + location);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User("serdar", "istanbul");
            u.GetUserDetails();
            Console.ReadLine();
        }
    }
}
