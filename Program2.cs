using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void Main()
        {
            
            

            Student Student1 = new Student();
            Student1.SetAge(21);
            
            Student1.ShowAge();
            Student1.Study();

            Teacher Teacher1 = new Teacher();
            Teacher1.SetAge(30);
            
            Teacher1.Explain();
        }
    }

    public class Person
    {
        protected int age;

       

        public void SetAge(int n)
        {
            age = n;
        }
    }

    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }

    
}

