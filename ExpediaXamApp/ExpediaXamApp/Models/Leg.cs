using System;
using System.Collections.Generic;
using System.Text;

namespace ExpediaXamApp.Models
{
    public class Leg
    {
        public string FlightMessage { get; set; }
        public uint FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string STD { get; set; }
        public string STA { get; set; }
        public uint DepartureGateNumber { get; set; }
        public uint ArrivalGateNumber { get; set; }
    }
}
