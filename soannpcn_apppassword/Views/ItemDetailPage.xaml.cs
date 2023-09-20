using soannpcn_apppassword.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace soannpcn_apppassword.Views
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