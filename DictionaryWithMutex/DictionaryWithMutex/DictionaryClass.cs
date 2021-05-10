using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryWithMutex
{
    class DictionaryClass
    {
        public static Dictionary<string, string> PilotAndAircraft = new Dictionary<string, string>();
        public bool interactiveSwitch = false;  //LOCATION FOR  SWITCH. Set true if want interations default is false.


        public void FillDictionary()
        {
            #region Fill elements
            PilotAndAircraft.Add("Joseph Bell", "F/A-18E/F Super Hornet");
            PilotAndAircraft.Add("Kenny Peck", "F-22 Raptor");
            PilotAndAircraft.Add("Daisy Mccray", "F/A-18E/F Super Hornet");
            PilotAndAircraft.Add("Laura Dixon", "F-35A Lightning II");
            PilotAndAircraft.Add("Leo Robinson", "A-10 Thunderbolt II");
            PilotAndAircraft.Add("Vance Blake", "F-22 Raptor");
            PilotAndAircraft.Add("Tanner Davis", "F-22 Raptor");
            PilotAndAircraft.Add("Kailee Bass", "F/A-18E/F Super Hornet");
            PilotAndAircraft.Add("Jessica Bennett", "UH-60 Black Hawk");
            PilotAndAircraft.Add("Meghan Good", "F-15C Eagle");
            PilotAndAircraft.Add("Sam Donovan", "A-10 Thunderbolt II");
            PilotAndAircraft.Add("Paxton Lucas", "F-35A Lightning II");
            PilotAndAircraft.Add("Abby Ward", "UH-60 Black Hawk");
            PilotAndAircraft.Add("Chloe Phillips", "F-35A Lightning II");
            PilotAndAircraft.Add("Evan Wells", "F-35A Lightning II");
            PilotAndAircraft.Add("Emerson Thompson", "F-35A Lightning II");
            PilotAndAircraft.Add("Peyton Burns", "F/A-18E/F Super Hornet");
            PilotAndAircraft.Add("Hadassah Jennings", "F-15C Eagle");
            PilotAndAircraft.Add("Dylan Hudson", "AC-130");
            PilotAndAircraft.Add("Kyle Wheeler", "MH-47 Chinook");
            PilotAndAircraft.Add("Ethan Dawson", "A-10 Thunderbolt II");
            PilotAndAircraft.Add("Ruby Burton", "F-15C Eagle");
            PilotAndAircraft.Add("Giada Roy", "F-35A Lightning II");
            PilotAndAircraft.Add("Millie Bell", "F-35A Lightning II");
            PilotAndAircraft.Add("Ashley Winters", "MH-47 Chinook");
            PilotAndAircraft.Add("Sara Barker", "MH/AH-6M Little Bird");
            PilotAndAircraft.Add("Owen Bradley", "F/A-18E/F Super Hornet");
            PilotAndAircraft.Add("Dennis Owens", "F-15C Eagle");
            PilotAndAircraft.Add("Eve Fox", "MH/AH-6M Little Bird");
            PilotAndAircraft.Add("Zara Bowman", "F-15C Eagle");
            PilotAndAircraft.Add("Jonathan Robertson", "AC-130");
            #endregion
        }
        public void NumberofSpecifiedAircraft() 
        {
            #region Valuecoll
            Dictionary<string, string>.ValueCollection valueColl =
            PilotAndAircraft.Values;
            int db = 0;
            string aircraft;
            Console.WriteLine("||Number of aircraft in database||");
            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of aircraft:");
                aircraft = Console.ReadLine();
            }
            else { aircraft = "F-35A Lightning II"; }
            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();

            foreach (string s in valueColl)
            {
                if (s == aircraft) { db++; }
            }
            Console.WriteLine("Number of {0} aircrafts in database is {1}.", aircraft, db);

            #endregion
        }
        public void InteractiveSwitchWarning() 
        {
            if (interactiveSwitch == false)
            {
                Console.WriteLine("Warning: Interactive Switch has been set to FALSE this means this program cannot be interacted with.");
                Console.WriteLine("RECCOMEND TO STAY IN THIS MODE. If wanted, it can be changed in source code at the marked location.");
                Console.WriteLine("Press any key, to continue....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Warning: Interactive Switch has been set to TRUE this means this program can be interacted with.");
                Console.WriteLine("You will be promted to interact with the program.");
                Console.WriteLine("RECCOMENDED MODE IS NON INTERACTIVE. If wanted, it can be changed in source code at the marked location.");
                Console.WriteLine("Press any key, to continue....");
                Console.ReadKey();
            }
           
        }
        public void TryGetValue()
        {
            #region TryGetValue
            string name;
            Console.WriteLine("||Try Getting Pilot's Aircraft||");

            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of pilot:");
                name = Console.ReadLine();
            }
            else { name = "Peyton Burns"; }
            if (PilotAndAircraft.TryGetValue(name, out string aircraft))
            {
             Console.WriteLine("Pilot named {0} has a {1}.",name, aircraft);
            }
            else
            {
                Console.WriteLine("There is no record of {0}.",name);
            }
            #endregion
        }
        public void  TryAddToDatabase() 
        {
            #region TryAdd
            string name, aircraft;
            // The Add method throws an exception if the new key is
            // already in the dictionary.
            Console.WriteLine("||Try adding pilot into Dictionary||");
            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of new pilot:");
                name = Console.ReadLine();
                Console.WriteLine("Enter pilot's aircraft:");
                aircraft = Console.ReadLine();
            }
            else
            {
                name = "Paxton Lucas";
                aircraft = "F-22 Raptor";
            }
            if (PilotAndAircraft.TryAdd(name,aircraft))
            {
                Console.WriteLine("TryAdd was succesfull!");
            }
            else
            {
                Console.WriteLine("TryAdd was unsuccesfull!");
            }
            #endregion
        }
        public void IsAircraftinDictionary() 
        {
            #region ContainsValue
            Console.WriteLine("||Aircraft in database||");
            string aircraft;
            if (interactiveSwitch == true)
            {
               
                Console.WriteLine("Enter name of aircraft: ");
                aircraft = Console.ReadLine();
            }
            else
            {
                aircraft = "F-22 Raptor";
            }

            if (!PilotAndAircraft.ContainsValue(aircraft)) 
            {
                Console.WriteLine("There is no {0} in the database.",aircraft);
            }
            else
            {
                Console.WriteLine("There is {0} in the database.", aircraft);
            }
            #endregion
        }
        public void ContainPilot() 
        {
            #region ContainsKey
            Console.WriteLine("||Dictionary contains pilot||");
            string name, aircraft;
            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of pilot:");
                name = Console.ReadLine();
                Console.WriteLine("Enter aircraft for pilot:");
                aircraft = Console.ReadLine();
            }
            else
            {
                name = "Kyle Wheeler";
                aircraft = "F/A-18E/F Super Hornet";
            }
            if (!PilotAndAircraft.ContainsKey(name))
            {
                PilotAndAircraft.Add(name, aircraft);
                Console.WriteLine("A new pilot named {0} added with a {1} aircraft.", name, PilotAndAircraft[name]);
            }
            else { Console.WriteLine("A pilot named {0} found in dictionary with {1}. Further action taken.", name, PilotAndAircraft[name]); }
            #endregion
        }
        public void ChangePsAircraft()
        {
            #region ChangePilotsAircraft
            // The indexer can be used to change the value associated
            // with a key.
            Console.WriteLine("||Change pilot's aircraft||");
            string name, aircraft;
            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of pilot:");
                name = Console.ReadLine();
                Console.WriteLine("Enter new aircraft for pilot:");
                aircraft = Console.ReadLine();
            }
            else { name = "Kenny Peck";
                aircraft = "F/A-18E/F Super Hornet"; }
            PilotAndAircraft[name] = aircraft;
            Console.WriteLine("Pilot named {0} aircraft has benn changed to {1}.", name, PilotAndAircraft[name]);
            #endregion
        }

        public void GetPilotsAircraft()
        {
            #region QueryForPilot
            string name;
            Console.WriteLine("||Pilot's aircraft||");
            
            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of pilot:");
                name = Console.ReadLine();
            }
            else { name = "Laura Dixon"; }
            Console.WriteLine("{0}'s aircraft is a {1}", name, PilotAndAircraft[name]);
            #endregion
        }

        public void NewPilotCheck()
        {
            #region NewPilotCheck
            string name, aircraft;
            // The Add method throws an exception if the new key is
            // already in the dictionary.
            Console.WriteLine("||New pilot into Dictionary||");
            if (interactiveSwitch == true)
            {
                Console.WriteLine("Enter name of new pilot:");
                name = Console.ReadLine();
                Console.WriteLine("Enter pilot's aircraft:");
                aircraft = Console.ReadLine();
            }
            else 
            { 
                name = "Joseph Bell";
                aircraft = "F-22 Raptor";
            }
            try
            {
                PilotAndAircraft.Add(name, aircraft);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("PilotAndAircraft has pilot named {0} already.", name);
            }
            #endregion
        }
       public void WriteThingsOut()
        {
            #region Write things


            // To get the keys alone, use the Keys property.
            Dictionary<string, string>.KeyCollection keyColl =
                PilotAndAircraft.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            Console.WriteLine("Pilots in database:");
            foreach (string s in keyColl)
            {
                Console.WriteLine("Pilot: {0}", s);
            }


            Dictionary<string, string>.ValueCollection valueColl =
            PilotAndAircraft.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            Console.WriteLine("Aircrafts in database:");
            foreach (string s in valueColl)
            {
                Console.WriteLine("Aircraft: {0}", s);
            }
            Console.WriteLine();
            Console.WriteLine("Combined database:");
            foreach (string s in keyColl)
            {
                Console.WriteLine("Pilot: {0} || Aircraft: {1}", s, PilotAndAircraft[s]);
            }
            #endregion 
        }
    }
}
