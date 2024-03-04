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

        private int currentWagon = 0;

        private Animal lastAnimal;

        // Constructor

        public void CreateWagon(Animal animal)
        {
            Wagon wagon = new Wagon(animal);
            AddWagons(wagon);

            Program.Debug($"TRAIN DEBUG: Wagon created."); 
        }

        public void CreateAnimals(int amount, Enums.AnimalSize size, Enums.AnimalType type)
        {
            for (int i = 0; i < amount; i++)
            {
                Animal animal = new Animal(size, type);
                AddAnimals(animal);

                Program.Debug($"TRAIN DEBUG: Animal created. \nAnimal Type: {animal.Type} | Animal Size: {animal.Size}.");
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

            Program.Debug($"TRAIN DEBUG: All animals created.");

            ReversedAnimals = Animals.ToList();
            ReversedAnimals.Reverse();

            FirstSort(Animals);

            Program.Debug($"TRAIN DEBUG: First sort completed with first list."); 

            TempWagons = Wagons.ToList();

            Wagons.Clear();
            currentWagon = 0;
            lastAnimal = null; 
            
            FirstSort(ReversedAnimals); 

            Program.Debug($"TRAIN DEBUG: First sort completed with second list.");

            if (TempWagons.Count < Wagons.Count)
            {
                Wagons = TempWagons;
            }
        }

        private void FirstSort(List<Animal> animals)
        {
            foreach (Animal animal in animals.ToList())
            {
                if (animal.Type == Enums.AnimalType.Carnivore)
                {
                    CreateWagon(animal);

                    animals.Remove(animal);
                }
            }

            SecondSort(animals);
        }

        private void SecondSort(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if (lastAnimal != animal && lastAnimal != null)
                {
                    currentWagon = 0;

                    Program.Debug($"TRAIN DEBUG: Last animal has been placed. Current Wagon reset.");
                }

                lastAnimal = animal;

                if (Wagons.Count == 0)
                {
                    CreateWagon(animal);

                    Program.Debug($"TRAIN DEBUG: First wagon created.");
                }
                else
                {
                    foreach (Wagon wagon in Wagons.ToList())
                    {
                        if (wagon.Points + animal.Points <= 10)
                        {
                            Program.Debug($"TRAIN DEBUG: Animal fits according to points. \nTotal points {wagon.Points + animal.Points}.");

                            if (wagon.CanAdd(animal))
                            {
                                wagon.AddAnimal(animal);

                                Program.Debug($"TRAIN DEBUG: Animal added to wagon. \nAnimal Type: {animal.Type} Animal Size: {animal.Size}.");

                                break;
                            }
                            else
                            {
                                CheckLastWagon(animal);
                            }
                        }
                        else
                        {
                            CheckLastWagon(animal);
                        }
                    }
                }
            }
        }

        // Methods 

        public void CheckLastWagon(Animal animal)
        {
            currentWagon++;

            if (currentWagon == Wagons.Count)
            {
                CreateWagon(animal);

                Program.Debug($"TRAIN DEBUG: Last Wagon reached.");
            }

            Program.Debug($"TRAIN DEBUG: Checked for Last Wagon.");
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
