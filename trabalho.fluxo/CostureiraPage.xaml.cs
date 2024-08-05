using Microsoft.Maui.Controls;

namespace trabalho.fluxo
{
    public partial class CostureiraPage: ContentPage
    {
        public CostureiraPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var   
 resposta = await DisplayAlert("Confirmação", "Tem certeza que deseja salvar?", "Sim", "Não");
            if (resposta)
            {
                // Aqui você implementaria a lógica para salvar os dados, por exemplo, enviando para um banco de dados
                await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
            }
        }
    }
}
    