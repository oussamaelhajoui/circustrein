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
            var AnimalsInDanger = AnimalsInJoint.Where(animal => newAnimal.Points >= animal.Points && newAnimal.EatOption == EatingOptions.Vlees);
            if(!AnimalsInDanger.Any() && (Capacity + newAnimal.Points) < 10) { return AddAnim(newAnimal); } else { return false; }
        }

       

        private bool AddAnim(Animal newAnimal)
        {
            Capacity += newAnimal.Points;
            AnimalsInJoint.Add(newAnimal);
            return true;
        }


    }
}
