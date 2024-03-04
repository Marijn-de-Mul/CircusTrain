using CircusTrain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {

        // Variables

        private static bool debug = true; 
        private static bool output = true;

        // Static Methods

        static void Main(string[] args)
        {
            Train train = new Train();

            Debug($"DEBUG: Train object created. Info: {train}");

            train.Create(Input.SmallCarnivore, Input.MediumCarnivore, Input.LargeCarnivore, Input.SmallHerbivore, Input.MediumHerbivore, Input.LargeHerbivore);

            Debug($"DEBUG: Train created.");
            
            if (output)
            {
                int counter = 0;

                foreach (Wagon wagon in train.Wagons)
                {
                    counter++;

                    Console.WriteLine($"[{counter}] | Amount of Animals: {wagon.Animals.Count} | Amount of Points: {wagon.Points}.");

                    foreach (Animal animal in wagon.Animals)
                    {
                        Console.WriteLine($"Size: {animal.Size} | Type: {animal.Type} | Points: {animal.Points}.");
                    }
                }
            }

            Debug($"DEBUG: Finished.");

            Console.ReadLine();
        }

        public static void Debug(string message)
        {
            if (debug)
            {
                Console.WriteLine(message);
            }
        }   
    }
}