using DayTrip_NJ.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DayTrip_NJ.Views
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