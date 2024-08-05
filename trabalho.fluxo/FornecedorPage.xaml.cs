using Microsoft.Maui.Controls;

namespace trabalho.fluxo
{
    public partial class FornecedorPage: ContentPage
    {
        public FornecedorPage()
        {
            InitializeComponent();
        }
    
        private void  CadastrarClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Cadastrado", "Fornecedor cadastrado com sucesso", "OK");
        }
    }
}