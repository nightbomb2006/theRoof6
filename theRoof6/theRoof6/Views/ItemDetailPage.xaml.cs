using System.ComponentModel;
using theRoof6.ViewModels;
using Xamarin.Forms;

namespace theRoof6.Views
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