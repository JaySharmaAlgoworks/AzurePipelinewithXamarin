using AzurePipelinewithXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AzurePipelinewithXamarin.Views
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