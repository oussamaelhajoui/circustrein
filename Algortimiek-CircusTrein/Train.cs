using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgortimiekCircusTrein
{
    class Train
    {
        public List<TrainWagon> wagonList = new List<TrainWagon>();

        public void AddAnimalToTrain(Animal a) // add animal to wagon 
        {
            foreach (TrainWagon wagon in wagonList)
            {
                if (wagon.AddAnimal(a))
                {
                    return;
                }
            }
            int id = (wagonList.Count > 0) ? wagonList.Count + 1  : 1; // getting the new id.
            wagonList.Add(new TrainWagon(id));
            AddAnimalToTrain(a); // if animal did not fit in the wagon it will create a new wagon and add it in that wagon.
        }
    }
}
