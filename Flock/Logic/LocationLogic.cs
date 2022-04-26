using Flock.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Flock.Logic
{
    public static class LocationLogic
    {
        public static void GetLocation(String provinceName, ref ResponseModel response)
        {
            var a = CallGobApi(provinceName).GetAwaiter().GetResult();

            //if (provModel.ProvinceList.Count > 0)
            //{
            //    response.Type = "OK";
            //    response.Data = provModel.ProvinceList[0].Location;
            //}
            //else
            //{
            //    response.Type = "Error";
            //    response.Message = "No se encontraron provincias";
            //}
        }

        public static async Task<ProvinceModel> CallGobApi(String provinceName)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://apis.datos.gob.ar/georef/api/provincias?nombre=" + provinceName);
                
                return JsonConvert.DeserializeObject<ProvinceModel>(json);
            }
        }
    }
}