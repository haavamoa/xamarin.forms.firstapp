using MyFirstApp.ViewModels;
using Xamarin.Forms;

namespace MyFirstApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}