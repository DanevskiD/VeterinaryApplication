using Microsoft.VisualStudio.TestTools.UnitTesting;
using VeterinaryApplication.Models;
using VeterinaryTestProject1.TestData;

namespace VeterinaryTestProject1.ModelTest
{
    [TestClass]
    public class OwnerTest
    {
        [TestMethod]
        public void OwnerProperties_ReturnCorrectValues()
        {
            // Arrange
            Owner owner = OwnerModelTestData.Owner;

            // Act
            string getFirstNameAndLastName = owner.getFirstNameAndLastName();

            // Assert
            Assert.AreEqual($"{owner.FirstName} {owner.LastName}", getFirstNameAndLastName);

            // Additional assertion for the Years property
            Assert.IsTrue(owner.Years >= 18 && owner.Years <= 100, "Years should be between 18 and 100.");
        }
    }
}
