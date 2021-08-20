using Pickup.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pickup.Views
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