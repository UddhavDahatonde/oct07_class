using System;
using System.Threading;

namespace oct07_class
{
    public class Program
    {
        public void Run1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            lock (t)
            for (int i = 1; i <=5; i++)
            { 
                Console.WriteLine(i);
               
            }
        }
        public void Run2()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
           // lock(this)
            for (int i = 6; i <=10; i++)
            {
                Console.WriteLine(i);
               
            }
        }
        
    }
    public class Demo
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Thread t1=new Thread(new ThreadStart(program.Run1));
            Thread t2=new Thread(new ThreadStart(program.Run2));
            Thread t3 = new Thread(new ThreadStart(program.Run2));
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t3.Name = "Thread3";

            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}
