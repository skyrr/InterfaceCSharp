using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person u = new User();
            Person t = new Teacher();

            u.Say();
            t.Say();

            Console.Read();
        }
    }
    public interface Person
    {
        void Say();
    }
    class User : Person
    {
        public void Say()
        {
            Console.WriteLine("I am a User");
        }
    }

    class Teacher : Person
    {
        public void Say()
        {
            Console.WriteLine("I am a Teacher");
        }
    }
}
