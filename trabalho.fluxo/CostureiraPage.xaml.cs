using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.fluxo
{
    public partial class CostureiraPage: ContentPage

    {  
        public Costureira costureira;
        public CostureiraPage()
        {
            InitializeComponent();
        }

        public object NomeEntry { get; private set; }
        public object CostureiraControles { get; private set; }
        public object EnderecoEntry { get; private set; }
        public object CPFEntry { get; private set; }
        public object EmailEntry { get; private set; }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var   
 resposta = await DisplayAlert("Confirmação", "Tem certeza que deseja salvar?", "Sim", "Não");
            if (resposta)
            {
                async void CadastrarCostureiraClicked(object sender, EventArgs e)
        {
            var cliente = new Modelos.Costureira();
            cliente.Nome = NomeEntry.Text;
            cliente.Endereço = EnderecoEntry.Text;
            cliente.CPF = CPFEntry.Text;
            cliente.Email = EmailEntry.Text;


            costureiraControle.CriarOuAtualizar(costureira);

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }


            }
        }
    }
}
    