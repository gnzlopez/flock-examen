using Flock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flock.Logic
{
    public static class LoginLogic
    {
        private static Boolean isLogin = false;

        // -- Simulo una lectura de datos
        private static List<UserModel> Users
        {
            get
            {
                var ListUser = new List<UserModel>();
                ListUser.Add(new UserModel() { UserID = 1, UserName = "Usuario", UserPass = "Contra" });
                return ListUser;
            }
        }

        public static void Login(UserModel oUser, ref ResponseModel response)
        {
            var user = GetUser(oUser.UserName);
            isLogin = user != null && user.UserPass == oUser.UserPass;

            if (isLogin)
            {
                response.Type = "OK";
                response.Data = user;
            }
            else
            {
                response.Type = "Error";
                response.Message = "Datos invalidos";
            }
        }

        private static UserModel GetUser(string userName)
        {
            return Users.Find(u => u.UserName == userName);
        }
    }
}