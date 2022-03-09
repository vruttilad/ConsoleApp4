using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram start = new StartProgram();
            start.activity += Start_activity;
            start.StartProcess();
        }

        private static void Start_activity()
        {
            Console.WriteLine("hiiiiiii");
            Console.ReadLine();
        }
    }
}
