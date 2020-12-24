using CustomXamarin.CustomRender;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomRenderPage : ContentPage
    {
        public CustomRenderPage()
        {
            InitializeComponent();
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Hello, Custom Renderer !",
                    },
                    new MyEntry {
                        Text = "In Shared Code",
                    }
                },
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}