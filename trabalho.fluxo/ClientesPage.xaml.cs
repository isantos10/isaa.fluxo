using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace trabalho.fluxo
{
    public partial class ClientesPage : ContentPage
    {
        public ObservableCollection<Client> Clients { get; set; }

        public ClientesPage()
        {
            InitializeComponent();

            Clients = new ObservableCollection<Client>
            {
                new Client { Name = "João" },
                new Client { Name = "Maria" },
                new Client { Name = "José" },
                new Client { Name = "Pedro" },
                new Client { Name = "Thiago" }
            };

            ClientsCollectionView.ItemsSource = Clients;
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

    public class Client
    {
        public string Name { get; set; }
    }
}
