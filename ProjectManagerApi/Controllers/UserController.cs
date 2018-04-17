using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using BusinessLayer;
using System.Web.Mvc;

namespace ProjectManagerApi.Controllers
{
    [System.Web.Http.Route("User")]
    public class UserController : ApiController
    {
        UserBusiness oUserBusines = new UserBusiness();
       
        [System.Web.Http.Route("GetAllUsers")]
        public IEnumerable<UserModel> GetAllUsers()
        {
          return  oUserBusines.GetAllUsers();
        }
        [System.Web.Http.Route("AddUser")]
        public UserUpdateResult AddUser(UserModel oUser)
        {
            return oUserBusines.UpdateUser(oUser);
            
        }
        [System.Web.Http.Route("DeleteUser")]
        public Status DeleteUser(UserModel oUser)
        {
            return oUserBusines.DeleteUser(oUser);
        }
    }
}