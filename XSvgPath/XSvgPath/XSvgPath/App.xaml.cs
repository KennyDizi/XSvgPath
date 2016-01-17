using Xamarin.Forms;

namespace XSvgPath
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ViaXamlView());
        }
    }
}
