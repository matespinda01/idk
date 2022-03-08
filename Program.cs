using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFactoryFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Karakter[] k = new Karakter[10];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = new Karakter();
            }
            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length-1; i++)
            {
                System.Threading.Thread.Sleep(100);
                taskArray[i] = Task.Factory.StartNew(() => k[i].Move());
            }
            while (true)
            {
                for (int i = 0; i < k.Length; i++)
                {
                    k[i].Draw();
                }
            }
           
           
            //Félkész
        }
    }
}
