﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class InitialLocation
    {
        [JsonProperty("longitude")]
        [JsonPropertyName("longitude")]
       public  double Longitude{ get; set; }
        [JsonProperty("latitude")]
        [JsonPropertyName("latitude")]
        public double Latitude{ get; set; }
        [JsonProperty("date_time")]
        [JsonPropertyName("date_time")]
        public string Date_time { get; set; }
    }

}
