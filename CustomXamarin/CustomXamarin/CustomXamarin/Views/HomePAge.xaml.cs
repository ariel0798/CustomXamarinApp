using CustomXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }
    }
}