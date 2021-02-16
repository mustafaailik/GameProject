using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "öznur" && gamer.LastName=="krsy" && gamer.NationalityId == "12345" && gamer.DateOfBirth == 1998)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
