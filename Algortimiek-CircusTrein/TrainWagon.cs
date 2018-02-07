using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgortimiekCircusTrein
{
    public class TrainWagon
    {
        public int Capacity { get; private set; }
        public int ID { get; private set; }
        public int MaxCapacity { get; } = 10;
        public List<Animal> AnimalsInJoint = new List<Animal>();

        public TrainWagon(int _ID)
        {
            ID = _ID;
        }

        public bool AddAnimal(Animal newAnimal)
        {
            if (Capacity == 0) // als wagon leeg is kan het dier erin
            {
                AddAnim(newAnimal);
                return true;
            }
            else if (newAnimal.Points == 5 && newAnimal.EatOption == EatingOptions.Vlees) //  als het wagon niet leeg is en het dier 5 punten waard is en een vlees eter is dan mag hij er niet in.
            {
                return false;
            }

            if (Capacity == MaxCapacity) { return false; } // als  het wagon vol is dan mag het dier er niet in.

            if ((Capacity + newAnimal.Points) > 10) { return false; } // als het wagon overvol raakt door het nieuwe dier dan mag het dier er niet in.
            else
            {
                if (newAnimal.EatOption == EatingOptions.Vlees) // if animal eats meat.
                {
                    foreach (Animal animInTrain in AnimalsInJoint)
                    {
                        if (animInTrain.Points <= newAnimal.Points)
                        {
                            return false;
                        }
                        if (animInTrain.Points >= newAnimal.Points && animInTrain.EatOption == EatingOptions.Vlees)
                        {
                            return false;
                        }
                    }
                }
                else // if animal eats plants.
                {
                    foreach (Animal animInTrain in AnimalsInJoint)
                    {
                        if (animInTrain.EatOption == EatingOptions.Vlees && animInTrain.Points >= newAnimal.Points)
                        {
                            return false;
                        }
                        else
                        {
                            AddAnim(newAnimal);
                            return true;
                        }
                    }
                }
            }

            AddAnim(newAnimal);
            return true;
        }

        private void AddAnim(Animal newAnimal)
        {
            Capacity += newAnimal.Points;
            AnimalsInJoint.Add(newAnimal);
        }


    }
}
