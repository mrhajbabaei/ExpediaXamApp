using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using ExpediaXamApp.Converters;
using ExpediaXamApp.Models;

namespace ExpediaXamApp.ViewModels
{
    public class FlightsPageViewModel : BaseViewModel
    {
        private string _pageTitle;
        private Leg _selectedLeg;
        private Leg _flightMessageLeg;
        private Leg _boardingMessageLeg;
        private Leg _placeLeg;
        private Leg _timeLeg;
        private List<Leg> _legs;

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }

        public Leg FlightMessageLeg
        {
            get { return _flightMessageLeg; }
            set
            {
                _flightMessageLeg = value;
                OnPropertyChanged();
            }
        }

        public Leg BoardingMessageLeg
        {
            get { return _boardingMessageLeg; }
            set
            {
                _boardingMessageLeg = value;
                OnPropertyChanged();
            }
        }

        public Leg PlaceLeg
        {
            get { return _placeLeg; }
            set
            {
                _placeLeg = value;
                OnPropertyChanged();
            }
        }

        public Leg TimeLeg
        {
            get { return _timeLeg; }
            set
            {
                _timeLeg = value;
                OnPropertyChanged();
            }
        }

        public List<Leg> Legs
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
                    FlightMessageLeg = _selectedLeg;
                    BoardingMessageLeg = _selectedLeg;
                    PlaceLeg = _selectedLeg;
                }
            }
        }

        public FlightsPageViewModel()
        {
            PageTitle = "Flights Page";
            Legs = GetLegs();
        }

        private List<Leg> GetLegs()
        {
            return new List<Leg>
            {
                new Leg() { FlightNumber=152, Departure="IKA", Arrival="DXP", STD="09:00", STA="12:00", ATD="", ATA="", DepartureGateNumber=20, ArrivalGateNumber=52 },
                new Leg() { FlightNumber=152, Departure="DXP", Arrival="IKA", STD="16:00", STA="19:00", ATD="", ATA="", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=152, Departure="THR", Arrival="MHD", STD="08:00", STA="10:00", ATD="08:10", ATA="10:10", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=152, Departure="MHD", Arrival="KER", STD="11:00", STA="13:00", ATD="11:10", ATA="13:10", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=152, Departure="KER", Arrival="MHD", STD="14:00", STA="15:00", ATD="14:10", ATA="15:10", DepartureGateNumber=27, ArrivalGateNumber=85 },
                new Leg() { FlightNumber=152, Departure="MHD", Arrival="THR", STD="16:00", STA="17:00", ATD="16:10", ATA="17:10", DepartureGateNumber=27, ArrivalGateNumber=85 }

            };
        }
    }
}
