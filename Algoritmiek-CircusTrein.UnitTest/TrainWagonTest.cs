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
    }
}
