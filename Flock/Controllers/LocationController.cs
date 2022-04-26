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
        LocationLogic _locationLogic;

        public LocationController()
        {
            _locationLogic = new LocationLogic();
        }

        public ResponseModel GetLocation(String provinceName)
        {
            var response = new ResponseModel();
            try
            {
                _locationLogic.GetLocation(provinceName, ref response);
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