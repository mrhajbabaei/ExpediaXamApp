using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ExpediaXamApp.Models
{
    public class Rootobject
    {
        [JsonProperty(PropertyName = "flight-wrappers")]
        public List<FlightWrapper> flightWrappers { get; set; }
    }

    public class FlightWrapper
    {
        [JsonProperty("id ")]
        public long Id { get; set; }

        [JsonProperty("flightNumber ")]
        public long FlightNumber { get; set; }

        [JsonProperty("departure ")]
        public string Departure { get; set; }

        [JsonProperty("arrival ")]
        public string Arrival { get; set; }

        [JsonProperty("std ")]
        public string Std { get; set; }

        [JsonProperty("sta ")]
        public string Sta { get; set; }

        [JsonProperty("atd ")]
        public string Atd { get; set; }

        [JsonProperty("ata ")]
        public string Ata { get; set; }

        [JsonProperty("departureGateNumber ")]
        public long DepartureGateNumber { get; set; }

        [JsonProperty("arrivalGateNumber ")]
        public long ArrivalGateNumber { get; set; }
    }
}
