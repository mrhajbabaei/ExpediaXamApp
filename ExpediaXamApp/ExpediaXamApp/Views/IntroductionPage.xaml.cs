using ExpediaXamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpediaXamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
            BindingContext = new IntroductionPageViewModel();
		}
	}
}