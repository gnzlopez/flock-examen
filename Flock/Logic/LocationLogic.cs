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
            var provResult = CallGobApi(provinceName).Result;

            LogLogic.Log("Proceso resultado del WS de Provincias ");

            if (provResult.ProvinceList.Count > 0)
            {
                response.Type = "OK";
                response.Data = provResult.ProvinceList[0].Location;
            }
            else
            {
                response.Type = "Error";
                response.Message = "No se encontraron provincias";
            }
        }

        public static async Task<ProvinceModel> CallGobApi(String provinceName)
        {
            LogLogic.Log("Llamo al WS de Provincias ");

            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://apis.datos.gob.ar/georef/api/provincias?nombre=" + provinceName)
                             .ConfigureAwait(continueOnCapturedContext: false);

                return JsonConvert.DeserializeObject<ProvinceModel>(json);

            }
        }
    }
}