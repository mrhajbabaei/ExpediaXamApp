using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpediaWebApi.Models
{
    public class FlightItem
    {
        public long Id { get; set; }
        public uint FlightNumber { get; set; }
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
