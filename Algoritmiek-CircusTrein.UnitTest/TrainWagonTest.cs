using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgortimiekCircusTrein;

namespace AlgoritmiekCircusTrein.UnitTest
{
    [TestClass]
    public class TrainWagonTest
    {
        [TestMethod]
        public void AddAnimal_AnimalIsCarnivorAndBigToEmptyWagon_ReturnsTrue()
        {
            // Arange
            int tempID = 1;
            var NewTrainWagon = new TrainWagon(tempID);

            // Act
            var result = NewTrainWagon.AddAnimal(new Animal("TestName", EatingOptions.Vlees, AnimalSizes.Groot));

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_AnimalIsCarnivorAndBiggerOrSameSizeThanOtherAnimalsInWagon_ReturnsFalse()
        {
            // Arange
            int tempID = 1;
            var NewTrainWagon = new TrainWagon(tempID);

            // Act
            var result1 = NewTrainWagon.AddAnimal(new Animal("TestName", EatingOptions.Planten, AnimalSizes.Middel));
            var result2 = NewTrainWagon.AddAnimal(new Animal("TestName", EatingOptions.Vlees, AnimalSizes.Groot));

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void AddAnimal_AnimalIsPlantEaterAndBigToEmptyWagon_ReturnsTrue()
        {
            // Arange
            int tempID = 1;
            var NewTrainWagon = new TrainWagon(tempID);

            // Act
            var result = NewTrainWagon.AddAnimal(new Animal("TestName", EatingOptions.Planten, AnimalSizes.Groot));

            // Assert
            Assert.IsTrue(result);
        }
    }
}
