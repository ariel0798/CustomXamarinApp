using Android.Content;
using Android.Runtime;
using Android.Views;
using CustomXamarin.Services.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(CustomXamarin.Droid.Services.DeviceOrientationService))]
namespace CustomXamarin.Droid.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}