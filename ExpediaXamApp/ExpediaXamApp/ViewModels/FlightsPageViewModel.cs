using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using ExpediaXamApp.Models;

namespace ExpediaXamApp.ViewModels
{
    class FlightsPageViewModel : BaseViewModel
    {
        private string _pageTitle = "Flights Page";
        public ObservableCollection<Leg> Legs { get; set; }

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }


    }
}
