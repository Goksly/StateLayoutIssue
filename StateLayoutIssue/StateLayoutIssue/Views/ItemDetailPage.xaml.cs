using StateLayoutIssue.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StateLayoutIssue.Views
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