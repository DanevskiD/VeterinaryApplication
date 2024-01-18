using Microsoft.VisualStudio.TestTools.UnitTesting;
using VeterinaryApplication.Models;
using VeterinaryTestProject1.TestData;

namespace VeterinaryTestProject1.ModelTest
{
    [TestClass]
    public class PetTest
    {
        [TestMethod]
        public void PetProperties_ReturnCorrectValues()
        {
            // Arrange
            Pet pet = PetModelTestData.Pet;

            // Act
            string petDetails = pet.GetPetDetails();

            // Assert
            Assert.IsTrue(pet.Age >= 0 && pet.Age <= 50, "Age should be between 0 and 50.");
            Assert.AreEqual($"Pet Name: {pet.Name}, Age: {pet.Age}, Owner ID: {pet.OwnerId}", petDetails);
        }
    }
}
