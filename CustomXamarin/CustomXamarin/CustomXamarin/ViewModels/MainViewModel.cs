using CustomXamarin.Services.Interfaces;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomXamarin.ViewModels
{
    public class MainViewModel
    {
        public ICommand GetOrientantion => new Command(async () => await GetOrientation());

        async Task GetOrientation()
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();

            await App.Current.MainPage.DisplayAlert("Orientation", $"The orientation is " + orientation.ToString(), "Ok");
        }
    }
}
