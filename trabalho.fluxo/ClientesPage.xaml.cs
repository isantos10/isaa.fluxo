using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.fluxo
{
    public partial class ClientesPage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public Cliente cliente;

        public ClientesPage()
        {

            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabel.Text = cliente.Id.ToString();
                NomeEntry.Text = cliente.Nome;
                EnderecoEntry.Text = cliente.Endereço;
                CPFEntry.Text = cliente.CPF;


            }
        }
        private async void CadastrarClienteClicked(object sender, EventArgs e)
        {

            {
                var cliente = new Cliente();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.Id = int.Parse(IdLabel.Text);
                else
                    cliente.Id = 0;
                cliente.Nome = NomeEntry.Text;
                cliente.Endereço = EnderecoEntry.Text;
                cliente.CPF = CPFEntry.Text;
                clienteControle.CriarOuAtualizar(cliente);

                await DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
            }
        }


        void VoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaClientePage();
        }
        private async void ApagarClienteClicked(object sender, EventArgs e)
        {

            if (cliente == null || cliente.Id < 1)
                await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse cliente?", "Excluir Cliente", "cancelar"))
            {

                clienteControle.Apagar(cliente.Id);

                Application.Current.MainPage = new ListaClientePage();
            }
        }

    }


}
