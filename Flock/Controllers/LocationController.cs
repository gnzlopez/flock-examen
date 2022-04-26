using Flock.Logic;
using Flock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Flock.Controllers
{
    public class LocationController : ApiController
    {

        public ResponseModel GetLocation(String provinceName)
        {
            var response = new ResponseModel();
            try
            {
                LocationLogic.GetLocation(provinceName, ref response);
            }
            catch (Exception e)
            {
                LogLogic.Log($"Error:{e.Data} ");
                response.Type = "Error";
                response.Message = e.Message;
            }

            return response;
        }
    }
}