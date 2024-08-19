using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace trabalho.fluxo
{
    public partial class ClientesPage : ContentPage
    {
         Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public ClientesPage()
        {
            InitializeComponent();

            ListaClientes.ItemsSource = clienteControle.LerTodos();

        }

        private async void OnAddClientClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Novo Cliente", "Digite o nome do cliente:");
            if (!string.IsNullOrWhiteSpace(result))
            {
                Clients.Add(new Client { Name = result });
            }
        }

        private async void OnRemoveClientClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Client client = button.BindingContext as Client;

            bool confirm = await DisplayAlert("Tem certeza que deseja remover?", "", "sim", "não");
            if (confirm)
            {
                Clients.Remove(client);
            }
        }
    }


}
