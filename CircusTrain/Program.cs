using CircusTrain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain 
{
    class Program
    {

        // Variables

        private static bool output = true;

        // Static Methods

        static void Main(string[] args)
        {
            Train train = new Train();

            train.Create(Input.SmallCarnivore, Input.MediumCarnivore, Input.LargeCarnivore, Input.SmallHerbivore, Input.MediumHerbivore, Input.LargeHerbivore);

            Output(train); 

            Console.ReadLine();
        }

        private static void Output(Train train)
        {
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
        }   
    }
}