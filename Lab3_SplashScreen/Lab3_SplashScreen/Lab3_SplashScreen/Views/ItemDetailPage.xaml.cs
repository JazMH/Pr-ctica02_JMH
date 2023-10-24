using Lab3_SplashScreen.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab3_SplashScreen.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}