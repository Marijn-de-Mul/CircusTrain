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

        private void AddAnimal(Animal animal)
        {
            Add(animal);
        }

        public bool TryAdd(Animal animal)
        {
            int points = 0; 

            foreach (Animal wagonAnimal in Animals)
            {
                points += wagonAnimal.Points;
            }

            foreach (Animal wagonAnimal in Animals)
            {
                if (wagonAnimal.Type == Enums.AnimalType.Carnivore && animal.Type == Enums.AnimalType.Carnivore)
                {
                    return false; 
                } 
                else if (wagonAnimal.Points >= animal.Points && wagonAnimal.Type == Enums.AnimalType.Carnivore)
                {
                    return false; 
                } 
                else if (points + animal.Points > 10)
                {
                    return false; 
                }
                else
                {
                    AddAnimal(animal);

                    return true; 
                }
            }

            return false; 
        }
    }
}
