using System;
using System.Collections.Generic;
using System.Text;

namespace ExpediaXamApp.Models
{
    public class Flight
    {
        public long Id { get; set; }
        public long FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string STD { get; set; }
        public string STA { get; set; }
        public string ATD { get; set; } = "";
        public string ATA { get; set; } = "";
        public uint DepartureGateNumber { get; set; }
        public uint ArrivalGateNumber { get; set; }
    }
}
