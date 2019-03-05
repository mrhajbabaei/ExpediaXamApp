using System;
using System.Collections.Generic;
using System.Text;

namespace ExpediaXamApp.ViewModels
{
    class FlightsPageViewModel : BaseViewModel
    {
        private string _pageTitle = "Flights Page";

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }

        public FlightsPageViewModel()
        {
            
        }
    }
}
