using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_
{
    internal class ApplicationStopWatch
    {
             

        internal static void RunApp()
        {
            var newCase = new Stopwatch();
            bool appOn = true;

            while (appOn)
            {
                Console.WriteLine("Choose a key:\ns - start timer\nf - end timer " +
                    "\nr - reset timer\ne - close application");


                var Key = Console.ReadKey().KeyChar;     
                
                Console.WriteLine();

                switch (Key)
                {
                    case 's':
                        newCase.Start();
                        break;
                    case 'f':
                        newCase.Stop();
                        break;
                    case 'r':
                        newCase.Reset();
                        break;
                    case 'e':
                        appOn = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Key!");
                        break;
                }
            }
        }


    }
}
