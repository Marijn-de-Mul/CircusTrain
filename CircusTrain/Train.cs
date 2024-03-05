using CSharpTutorials;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Train
    {

        // Variables 

        public List<Wagon> Wagons = new List<Wagon>();

        public List<Wagon> TempWagons = new List<Wagon>();

        public List<Animal> Animals = new List<Animal>();

        public List<Animal> ReversedAnimals = new List<Animal>();

        // Constructor

        public void CreateWagon(Animal animal)
        {
            Wagon wagon = new Wagon(animal);
            AddWagons(wagon);
        }

        public void CreateAnimals(int amount, Enums.AnimalSize size, Enums.AnimalType type)
        {
            for (int i = 0; i < amount; i++)
            {
                Animal animal = new Animal(size, type);
                AddAnimals(animal);
            }
        }

        // Internal Methods 

        internal void AddWagons(Wagon wagon)
        {
            Wagons.Add(wagon);
        }

        internal void AddAnimals(Animal animal)
        {
            Animals.Add(animal);
        }

        // Static Methods 

        public void Create(int smallCarnivore, int mediumCarnivore, int largeCarnivore, int smallHerbivore, int mediumHerbivore, int largeHerbivore)
        {
            CreateAnimals(smallCarnivore, Enums.AnimalSize.Small, Enums.AnimalType.Carnivore);
            CreateAnimals(mediumCarnivore, Enums.AnimalSize.Medium, Enums.AnimalType.Carnivore);
            CreateAnimals(largeCarnivore, Enums.AnimalSize.Large, Enums.AnimalType.Carnivore);
            CreateAnimals(smallHerbivore, Enums.AnimalSize.Small, Enums.AnimalType.Herbivore);
            CreateAnimals(mediumHerbivore, Enums.AnimalSize.Medium, Enums.AnimalType.Herbivore);
            CreateAnimals(largeHerbivore, Enums.AnimalSize.Large, Enums.AnimalType.Herbivore);

            Sort(); 
        }

        private void Sort()
        {
            ReversedAnimals = Animals.ToList();
            ReversedAnimals.Reverse();

            SortCarnivores(GetAllAnimalsOfType(Enums.AnimalType.Carnivore, Animals));
            SortHerbivores(GetAllAnimalsOfType(Enums.AnimalType.Herbivore, Animals));

            TempWagons = Wagons.ToList();

            Wagons.Clear();

            SortCarnivores(GetAllAnimalsOfType(Enums.AnimalType.Carnivore, ReversedAnimals));
            SortHerbivores(GetAllAnimalsOfType(Enums.AnimalType.Herbivore, ReversedAnimals));

            if (TempWagons.Count < Wagons.Count)
            {
                Wagons = TempWagons;
            }
        }

        private List<Animal> GetAllAnimalsOfType(Enums.AnimalType animalType, List<Animal> animals)
        {
            List<Animal> sortedAnimals = new List<Animal>(); 
 
            foreach (Animal animal in animals)
            {
                if (animal.Type == animalType)
                {
                    sortedAnimals.Add(animal);
                }
            }

            return sortedAnimals; 
        }

        private void SortCarnivores(List<Animal> animals) 
        {
            foreach (Animal animal in animals) 
            {
                CreateWagon(animal);
            }
        }

        private void SortHerbivores(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                bool placed = false;

                foreach (Wagon wagon in Wagons.ToList())
                {
                    if (wagon.TryAdd(animal))
                    {
                        placed = true;
                        break;
                    }
                }

                if (!placed)
                {
                    CreateWagon(animal);
                }
            }
        }
    }

    public class TrainTest
    {
        public static int UnitTestStart()
        {
            Train train = new Train();

            train.Create(Input.SmallCarnivore, Input.MediumCarnivore, Input.LargeCarnivore, Input.SmallHerbivore, Input.MediumHerbivore, Input.LargeHerbivore);

            return train.Wagons.Count;
        }
    }
}
