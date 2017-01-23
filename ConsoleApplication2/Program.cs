using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class student
    {
        string name;
        string surname;
        string full;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                full = name + ' ' + surname;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                full = name + ' ' + surname;
            }
        }
        public string Full { get { return full; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Name = "d";
            s.Surname = "t";
           
            Console.WriteLine(s.Full);
        }
    }
}
