using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using ExpediaXamApp.Converters;
using ExpediaXamApp.Models;
using Xamarin.Forms;

namespace ExpediaXamApp.ViewModels
{
    public class FlightsPageViewModel : BaseViewModel
    {
        private string _pageTitle;
        private Leg _selectedLeg;
        private ObservableCollection<Leg> _legs;

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Leg> Legs
        {
            get { return _legs; }
            set
            {
                _legs = value;
                OnPropertyChanged();
            }
        }

        public Leg SelectedLeg
        {
            get { return _selectedLeg; }
            set
            {
                if (_selectedLeg != value)
                {
                    _selectedLeg = value;
                    OnPropertyChanged();
                }
            }
        }

        public FlightsPageViewModel()
        {
            PageTitle = "Flights Page";
            Legs = GetLegs();
            DeleteFlightCommand = new Command(DeleteFlight);
        }

        private void DeleteFlight(object obj)
        {
            if ((obj as MenuItem).CommandParameter is Leg leg)
                _legs.Remove(leg);
        }

        public Command DeleteFlightCommand { get; set; }



        private ObservableCollection<Leg> GetLegs()
        {
            return new ObservableCollection<Leg>
            {
                new Leg() { FlightNumber=152, Departure="IKA", Arrival="DXP", STD="09:00", STA="12:00", ATD="", ATA="", DepartureGateNumber=20, ArrivalGateNumber=52 },
                new Leg() { FlightNumber=151, Departure="DXP", Arrival="IKA", STD="16:00", STA="19:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=14, Departure="THR", Arrival="MHD", STD="08:00", STA="10:00", ATD="08:10", ATA="10:10", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=13, Departure="MHD", Arrival="KER", STD="11:00", STA="13:00", ATD="11:00", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=12, Departure="KER", Arrival="MHD", STD="14:00", STA="15:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=11, Departure="MHD", Arrival="THR", STD="16:00", STA="17:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 }

            };
        }
    }
}
