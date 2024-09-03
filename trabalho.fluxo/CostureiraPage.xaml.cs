using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.fluxo
{
    public partial class CostureiraPage: ContentPage

    {  
        public Costureira costureira;
        Controles.CostureiraControle costureiraControle = new Controles.CostureiraControle();
        public CostureiraPage()
        {
            InitializeComponent();
        }
         protected override void OnAppearing()
        {
            base.OnAppearing();

            if (costureira != null)
            {
                IdLabel.Text = costureira.Id.ToString();
                EntryNome.Text = costureira.Nome;
                EntryEndereco.Text = costureira.Endereço;
            }
        }
       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var   
            resposta = await DisplayAlert("Confirmação", "Tem certeza que deseja salvar?", "Sim", "Não");
            if (resposta)
            {
                async void CadastrarCostureiraClicked(object sender, EventArgs e)
        {
            var cliente = new Modelos.Costureira();
            cliente.Nome = EntryNome.Text;
            cliente.Endereço = EntryEndereco.Text;
            cliente.CPF = EntryCPF.Text;
            cliente.Email = EntryEmail.Text;


            costureiraControle.CriarOuAtualizar(costureira);

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }
                 Application.Current.MainPage = new ListaCostureiraPage();

            }
        }
    }
}
    