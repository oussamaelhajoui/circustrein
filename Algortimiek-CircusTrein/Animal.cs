using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortimiek_CircusTrein
{
    public class Animal
    {
        public string Name { get; private set; }
        public EatingOptions EatOption { get; private set; }
        public AnimalSizes AnimalSize { get; private set; }

        public int Points { get; private set; }

        public Animal(string name, EatingOptions eatoption, AnimalSizes size)
        {
            Name = name;
            EatOption = eatoption;
            AnimalSize = size;

            switch (AnimalSize)
            {
                case AnimalSizes.Klein:
                    Points = 1;
                    break;
                case AnimalSizes.Middel:
                    Points = 3;
                    break;
                case AnimalSizes.Groot:
                    Points = 5;
                    break;
                default:
                    Points = 0;
                    break;
            }

        }


    }
}
