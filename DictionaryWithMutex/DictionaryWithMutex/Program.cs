using System;
using System.Collections.Generic;
using System.Threading;

/*
    Created by : Levente Simkó
    NK: YG5YAO
 */

namespace DictionaryWithMutex
{
    class Program
    {
        private static Mutex mut = new Mutex();
        private const int numThreads = 8;
        private static int numofOperation = 0;
        private static DictionaryClass PilotDictionary = new DictionaryClass();
        static void Main(string[] args)
        {
          
            PilotDictionary.FillDictionary();
            PilotDictionary.InteractiveSwitchWarning();
            PilotDictionary.WriteThingsOut();
            PilotDictionary.NumberofSpecifiedAircraft();
            for (int i = 0; i < numThreads; i++)
            {
                Thread newThread = new Thread(new ThreadStart(ThreadProc))
                {
                    Name = String.Format("ThreadSynch{0}", i + 1)
                };
                newThread.Start();
            }


        }
        private static void ThreadProc()
        {
            
                UseResource();
            numofOperation++;
        }
        private static void UseResource()
        {
            mut.WaitOne();

            Console.WriteLine("{0} has entered the protected area",
                              Thread.CurrentThread.Name);

            // Place code to access non-reentrant resources here.

            // Simulate some work.
            Console.WriteLine();
            if (numofOperation == 0)
            {
                PilotDictionary.NewPilotCheck();
            }
            else if (numofOperation == 1)
            {
                PilotDictionary.TryAddToDatabase();
            }
            else if (numofOperation == 2)
            {
                PilotDictionary.ContainPilot();
            }
            else if (numofOperation == 3)
            {
                PilotDictionary.TryGetValue();
            }
            else if (numofOperation == 4)
            {
                PilotDictionary.GetPilotsAircraft();
            }
            else if (numofOperation == 5)
            {
                PilotDictionary.ChangePsAircraft();
            }
            else if (numofOperation == 6)
            {
                PilotDictionary.IsAircraftinDictionary();
            }
            else { PilotDictionary.WriteThingsOut(); }


            Console.WriteLine("{0} is leaving the protected area",
                Thread.CurrentThread.Name);

            // Release the Mutex.
            mut.ReleaseMutex();
        }
       
    }
}
