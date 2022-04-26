using Flock.Logic;
using Flock.Models;
using Flock.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Flock.Controllers
{
    public class LoginController : ApiController
    {
        LoginLogic _logic;

        public LoginController()
        {
            _logic = new LoginLogic(new UserRepository());
        }

        [HttpPost]
        public ResponseModel Login([FromBody] UserModel oUser)
        {
            var response = new ResponseModel();
            try
            {
                _logic.Login(oUser, ref response);
            }
            catch (Exception e)
            {
                LogLogic.Log($"Error: {e.Data} ");
                response.Type = "Error";
                response.Message = e.Message;
            }

            return response;
        }
    }
}