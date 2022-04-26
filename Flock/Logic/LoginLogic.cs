using Flock.Models;
using Flock.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flock.Logic
{
    public class LoginLogic
    {
        private Boolean _isLogin;
        private IUserRepository _userRep;

        public LoginLogic(IUserRepository userRep)
        {
            _isLogin = false;
            _userRep = userRep;
        }

        public void Login(UserModel oUser, ref ResponseModel response)
        {
            LogLogic.Log("Inicia la busqueda de Usuario ");
            var user = _userRep.GetUser(oUser.UserName);
            _isLogin = user != null && user.UserPass == oUser.UserPass;

            if (_isLogin)
            {
                LogLogic.Log("Usuario logueado OK ");
                response.Type = "OK";
                response.Data = user;
            }
            else
            {
                LogLogic.Log("Usuario no logueado correctamente ");
                response.Type = "Error";
                response.Message = "Datos invalidos";
            }
        }
    }
}