using CSharpTutorials;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Wagon
    {

        // Variables 

        public List<Animal> Animals = new List<Animal>();

        public int Points { get; private set; } = 0; 

        // Constructor 

        public Wagon(Animal animal)
        {
            Add(animal); 
        }
        
        // Internal Methods 

        internal void Add(Animal animal)
        {
            Animals.Add(animal);
            Points += animal.Points;
        }

        // Methods 

        public void AddAnimal(Animal animal)
        {
            Add(animal);

            Program.Debug($"WAGON DEBUG: Animal added to Wagon. \nAnimal Type: {animal.Type} | Animal Size: {animal.Size}.");
        }

        public bool CanAdd(Animal animal)
        {
            foreach (Animal wagonAnimal in Animals)
            {
                if (wagonAnimal.Type == Enums.AnimalType.Carnivore && animal.Type == Enums.AnimalType.Carnivore)
                {
                    Program.Debug($"WAGON DEBUG: Animal not compatible with Wagon. \n New Animal [ Animal Type: {animal.Type} | Animal Size: {animal.Size} ] Old Animal [ Animal Type: {wagonAnimal.Type} | Animal Size: {wagonAnimal.Size} ].");
                    return false; 
                } 
                else if (wagonAnimal.Points >= animal.Points && wagonAnimal.Type == Enums.AnimalType.Carnivore)
                {
                    Program.Debug($"WAGON DEBUG: Animal not compatible with Wagon. \n New Animal [ Animal Type: {animal.Type} | Animal Size: {animal.Size} ] Old Animal [ Animal Type: {wagonAnimal.Type} | Animal Size: {wagonAnimal.Size} ].");
                    return false; 
                } 
                else
                {
                    Program.Debug($"WAGON DEBUG: Animal compatible with Wagon. \n New Animal [ Animal Type: {animal.Type} | Animal Size: {animal.Size} ] Old Animal [ Animal Type: {wagonAnimal.Type} | Animal Size: {wagonAnimal.Size} ].");
                    return true; 
                }
            }

            return false; 
        }
    }
}
