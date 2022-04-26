using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flock.Models
{
    public class ProvinceModel
    {
        [JsonProperty("provincias")]
        public List<Province> ProvinceList { get; set; }
    }

    public class Province
    {

        [JsonProperty("id")]
        public Int64 Id { get; set; }
        [JsonProperty("nombre")]
        public String Name { get; set; }
        [JsonProperty("centroide")]
        public Location Location { get; set; }
    }

    public class Location
    {
        [JsonProperty("lat")]
        public String Latitude { get; set; }
        [JsonProperty("lon")]
        public String Longitude { get; set; }
    }
}