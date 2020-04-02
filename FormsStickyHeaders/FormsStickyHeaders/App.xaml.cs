using Xamarin.Forms;
using FormsProofOfConcept.Views;

namespace FormsProofOfConcept
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new ItemsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
