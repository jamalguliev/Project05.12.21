using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HelloWorld";
            var arr = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
    }

