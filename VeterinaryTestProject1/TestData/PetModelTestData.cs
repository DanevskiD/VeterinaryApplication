using System.Collections.Generic;
using VeterinaryApplication.Models;

namespace VeterinaryTestProject1.TestData
{
    public class PetModelTestData
    {
        public static Pet Pet = new Pet
        {
            PetId = 1,
            Name = "Shelby",
            Age = 3,
            OwnerId = 6,
            Owner = new Owner
            {
                OwnerId = 6,
                FirstName = "Hristifor",
                LastName = "Sotirovski"
            },
          
        };
    }
}
