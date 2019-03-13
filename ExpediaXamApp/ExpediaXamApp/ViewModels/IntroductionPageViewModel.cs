using System.Threading.Tasks;
using ExpediaXamApp.Views;
using Xamarin.Forms;

namespace ExpediaXamApp.ViewModels
{
    public class IntroductionPageViewModel : BaseViewModel
    {
        private string _pageTitle = "Introduction Page";

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }

        public IntroductionPageViewModel()
        {
            ShowFlightsCommand = new Command(() =>
            {
                ShowFlights();
            });
        }

        public object ShowFlightsCommand { get; set; }

        public async Task ShowFlights()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FlightsPage());
        }


    }
}
