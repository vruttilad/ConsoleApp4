using System;

namespace ConsoleApp4
{
    public delegate void start();
    internal class StartProgram
    {


        public event start activity;
        public void StartProcess()
        {
            Console.WriteLine("\n Process started");
            Console.ReadLine();
            OncompletedProcess();
        }

        private void OncompletedProcess()
        {
            activity?.Invoke();
        }
    }
}