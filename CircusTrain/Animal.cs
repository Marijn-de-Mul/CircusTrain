using CSharpTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Animal
    {
        // Variables

        public Enums.AnimalSize Size { get; private set; } 

        public Enums.AnimalType Type { get; private set; }

        public int Points { get; private set; } = 0;

        // Constructor 

        public Animal(Enums.AnimalSize size, Enums.AnimalType type)
        {
            Size = size;
            Type = type;

            if (size == Enums.AnimalSize.Small)
            {
                Points += 1;
            }
            else if (size == Enums.AnimalSize.Medium)
            {
                Points += 3;
            }
            else if (size == Enums.AnimalSize.Large)
            {
                Points += 5;
            }

            Program.Debug($"ANIMAL DEBUG: Animal Created. \nAnimal Type: {size} | Animal Type {type} | Animal Points {Points}.");
        }
    }
}
