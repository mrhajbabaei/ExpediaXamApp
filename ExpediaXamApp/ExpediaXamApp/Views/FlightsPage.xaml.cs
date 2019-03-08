using ExpediaXamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpediaXamApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlightsPage : TabbedPage
	{
		public FlightsPage ()
		{
			InitializeComponent ();
            BindingContext = new FlightsPageViewModel();
		}
	}
}