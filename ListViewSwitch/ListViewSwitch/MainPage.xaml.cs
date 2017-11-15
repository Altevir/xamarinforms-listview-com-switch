using ListViewSwitch.Model;
using ListViewSwitch.ViewModel;
using Xamarin.Forms;

namespace ListViewSwitch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ClienteViewModel();
            lstView.ItemTapped += LstView_ItemTapped;
        }

        private async void LstView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var model = e.Item as Cliente;

            if (model == null)
                return;

            await DisplayAlert("Informação", "Selecionado: " + model.Selecionado, "OK");

            lstView.SelectedItem = null;
        }
    }
}
