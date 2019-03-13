using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ExpediaXamApp.Converters;
using ExpediaXamApp.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using Xamarin.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ExpediaXamApp.ViewModels
{
    public class FlightsPageViewModel : BaseViewModel
    {
        private string _pageTitle;
        private Flight _selectedFlight;
        private List<Flight> _flights;

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }

        public List<Flight> Flights
        {
            get { return _flights; }
            set
            {
                _flights = value;
                OnPropertyChanged();
            }
        }

        public Flight SelectedFlight
        {
            get { return _selectedFlight; }
            set
            {
                if (_selectedFlight != value)
                {
                    _selectedFlight = value;
                    OnPropertyChanged();
                }
            }
        }

        public FlightsPageViewModel()
        {
            PageTitle = "Flights Page";
            Flights = GetFlights();
            var result = GetFlightAsync();
            Console.WriteLine(result);
            //DeleteFlightCommand = new Command(DeleteFlight);
        }

        //private void DeleteFlight(object obj)
        //{
        //    if ((obj as MenuItem).CommandParameter is Flight leg)
        //        _flights.Remove(leg);
        //}

        //public Command DeleteFlightCommand { get; set; }



        private List<Flight> GetFlights()
        {
            return new List<Flight>
            {
                new Flight() { FlightNumber=152, Departure="IKA", Arrival="DXP", STD="09:00", STA="12:00", ATD="", ATA="", DepartureGateNumber=20, ArrivalGateNumber=52 },
                new Flight() { FlightNumber=151, Departure="DXP", Arrival="IKA", STD="16:00", STA="19:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Flight() { FlightNumber=14, Departure="THR", Arrival="MHD", STD="08:00", STA="10:00", ATD="08:10", ATA="10:10", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Flight() { FlightNumber=13, Departure="MHD", Arrival="KER", STD="11:00", STA="13:00", ATD="11:00", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Flight() { FlightNumber=12, Departure="KER", Arrival="MHD", STD="14:00", STA="15:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Flight() { FlightNumber=11, Departure="MHD", Arrival="THR", STD="16:00", STA="17:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 }

            };
        }

        private async Task<string> GetFlightAsync()
        {
//            ServicePointManager.ServerCertificateValidationCallback +=
//                (sender, certificate, chain, sslPolicyErrors) => true;
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, 15);

                HttpResponseMessage response = await client.GetAsync("https://172.20.34.185:44308/api/Flight");

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    return null;

                HttpContent content = response.Content;
                var result = await content.ReadAsStringAsync();
                return result;
            }
        }
        //public List<Flight> GetFlights(string uri= "https://localhost:44308/api/Flight")
        //{

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        //    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    using (Stream stream = response.GetResponseStream())
        //    using (StreamReader reader = new StreamReader(stream))
        //    {
        //        var stringValues = reader.ReadToEnd();
        //        Console.WriteLine(stringValues);
        //    }

        //    return new List<Flight>
        //        {
        //            new Flight() { FlightNumber=152, Departure="IKA", Arrival="DXP", STD="09:00", STA="12:00", ATD="", ATA="", DepartureGateNumber=20, ArrivalGateNumber=52 },
        //            new Flight() { FlightNumber=151, Departure="DXP", Arrival="IKA", STD="16:00", STA="19:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
        //            new Flight() { FlightNumber=14, Departure="THR", Arrival="MHD", STD="08:00", STA="10:00", ATD="08:10", ATA="10:10", DepartureGateNumber=27, ArrivalGateNumber=85 },
        //            new Flight() { FlightNumber=13, Departure="MHD", Arrival="KER", STD="11:00", STA="13:00", ATD="11:00", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
        //            new Flight() { FlightNumber=12, Departure="KER", Arrival="MHD", STD="14:00", STA="15:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
        //            new Flight() { FlightNumber=11, Departure="MHD", Arrival="THR", STD="16:00", STA="17:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 }

        //        };
        //}
    }
}
