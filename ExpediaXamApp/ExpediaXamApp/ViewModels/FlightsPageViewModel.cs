using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
            DeleteFlightCommand = new Command(DeleteFlight);

            var url = "http://localhost:6587/api/flight";
            var myXMLstring = "";
            Task.Run(() => myXMLstring = AccessTheWebAsync(url).Result).Wait();
//            var deserializeData = JsonConvert.DeserializeObject<Rootobject>(myXMLstring);
            Console.WriteLine(myXMLstring);
        }

        private void DeleteFlight(object obj)
        {
            if ((obj as MenuItem).CommandParameter is Flight leg)
                _flights.Remove(leg);
        }

        public Command DeleteFlightCommand { get; set; }



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

        async Task<String> AccessTheWebAsync(String url)
        {
            var handler = new HttpClientHandler();
            handler.Proxy = new WebProxy("http://172.20.34.185:8888");
            HttpClient client = new HttpClient(handler);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Task<string> getStringTask = client.GetStringAsync(url);
            string urlContents = await getStringTask;
            return urlContents;
        }

    }
}
