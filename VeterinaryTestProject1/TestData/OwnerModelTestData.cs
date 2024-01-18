using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryApplication.Controllers;
using VeterinaryApplication.Data;
using VeterinaryApplication.Models;
using VeterinaryApplication.Data;
namespace VeterinaryTestProject1.TestData
{
    public class OwnerModelTestData
    {
        public static Owner Owner = new Owner
        {
            OwnerId = 10,
            FirstName = "Nikola",
            LastName = "Person",
            Years = 25,
            Pets = new List<Pet>
        {
            new Pet { PetId = 10, Name = "Dalmatinec", Age = 2, OwnerId = 10 }
        }
        };
    };
};
