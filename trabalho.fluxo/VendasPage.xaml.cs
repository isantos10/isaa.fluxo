using Microsoft.Maui.Controls;

namespace trabalho.fluxo
{
    public partial class VendasPage: ContentPage
    {
        public VendasPage()
        {
            InitializeComponent();
        }
    
        private async void OnVendasClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmação", "Tem certeza que deseja vender?", "Sim", "Não");
            if (answer)
            {
                
                await DisplayAlert("Vendido", "Produto vendido com sucesso!", "OK");
            }
        }
    }
}