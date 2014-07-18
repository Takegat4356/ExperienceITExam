using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        private static List<Student> allStudents = new List<Student>
        {
            new Student {FirstName = "Alexandre", LastName="Levy" },
            new Student {FirstName = "Louis", LastName="Chauvin" },
            new Student {FirstName = "Robert", LastName="Johnson" },
            new Student {FirstName = "Nat", LastName="Jaffe" },
            new Student {FirstName = "Jesse", LastName="Belvin" },
            new Student {FirstName = "Rudy", LastName="Lewis" },
            new Student {FirstName = "Malcom", LastName="Hale" },
            new Student {FirstName = "Dickie", LastName="Pride" },
            new Student {FirstName = "Brian", LastName="Jones" },
            new Student {FirstName = "Alan (Blind Owl)", LastName="Wilson" },
            new Student {FirstName = "Jimi", LastName="Hendrix" },
            new Student {FirstName = "Janis", LastName="Joplin" },
            new Student {FirstName = "Alester (Dyke)", LastName="Christian" },
            new Student {FirstName = "Jim", LastName="Morrison" },
            new Student {FirstName = "Linda", LastName="Jones" },
            new Student {FirstName = "Leslie", LastName="Harvey" },
            new Student {FirstName = "Ron (Pigpen)", LastName="McKernan" },
            new Student {FirstName = "Roger Lee", LastName="Durham" },
            new Student {FirstName = "Wallace", LastName="Yohn" },
            new Student {FirstName = "Dave", LastName="Alexander" },
            new Student {FirstName = "Pete", LastName="Ham" },
            new Student {FirstName = "Gary", LastName="Thain" },
            new Student {FirstName = "", LastName="Celilia" },
            new Student {FirstName = "Helmut", LastName="Kollen" },
            new Student {FirstName = "Chris", LastName="Bell" },
            new Student {FirstName = "Jacob", LastName="Miller" },
            new Student {FirstName = "D", LastName="Boon" },
            new Student {FirstName = "Alexander", LastName="Bashlachev" },
            new Student {FirstName = "Jean-Michel", LastName="Basquiat" },
            new Student {FirstName = "Pete", LastName="de Freitas" },
            new Student {FirstName = "Mia", LastName="Zapata" },
            new Student {FirstName = "Kurt", LastName="Cobain" },
            new Student {FirstName = "Kristen", LastName="Pfaff" },
            new Student {FirstName = "Richey", LastName="Edwards" },
            new Student {FirstName = "Fat", LastName="Pat" },
            new Student {FirstName = "Freaky", LastName="Tah" },
            new Student {FirstName = "", LastName="Kami" },
            new Student {FirstName = "Rodigo", LastName="Bueno" },
            new Student {FirstName = "Maria Serrano", LastName="Serrano" },
            new Student {FirstName = "Jeremy Michael", LastName="Ward" },
            new Student {FirstName = "Bryan", LastName="Ottoson" },
            new Student {FirstName = "Valentin", LastName="Elizalde" },
            new Student {FirstName = "Amy", LastName="Winehouse" },
            new Student {FirstName = "Richard", LastName="Turner" },
            new Student {FirstName = "Nicole", LastName="Bogner" },
            new Student {FirstName = "Soroush (Looloosh)", LastName="Farazmand" },
            new Student {FirstName = "Monkey", LastName="Black" }
        };

        static void Main(string[] args)
        {
            //1. Write code to print all the names of all the studnets in the collection above.
            // 2. Modify the Student class to provide a method to print each students name.
            // 3. Use the method from (2) to print the students' names.
            Console.WriteLine(allStudents);
            Console.ReadLine();
        }
    }
}
