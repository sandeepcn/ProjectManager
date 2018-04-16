using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
namespace BusinessLayer
{
   public class UserBusiness
    {
        UserRepository repoUser = new UserRepository();
        public List<UserModel> GetAllUsers()
        {
            return repoUser.GetAllUsers().Select(x => new UserModel
            {
                Employee_ID = x.Employee_ID,
                First_Name = x.First_Name,
                Last_Name = x.Last_Name,
                Project_ID = x.Project_ID,
                User_ID = x.User_ID
            }).ToList();
        }
    }
}
