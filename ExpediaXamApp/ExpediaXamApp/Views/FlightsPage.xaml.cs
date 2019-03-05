using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpediaXamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpediaXamApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlightsPage : ContentPage
	{
		public FlightsPage ()
		{
			InitializeComponent ();
            BindingContext = new FlightsPageViewModel();
        }
	}
}