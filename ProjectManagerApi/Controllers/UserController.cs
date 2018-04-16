using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using BusinessLayer;



namespace ProjectManagerApi.Controllers
{
    
    public class UserController : ApiController
    {
        UserBusiness oUserBusines = new UserBusiness();
       
        
        public IEnumerable<UserModel> GetAllUsers()
        {
          return  oUserBusines.GetAllUsers();
        }
    }
}