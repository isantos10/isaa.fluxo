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
               
            }
        }

        private async void OnRemoveClientClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Tem certeza que deseja remover?", "", "sim", "não");
            if (confirm)
            {

            }
        }
         void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
   
    var page = new CadastroClientePage();
  
    page.cliente = e.SelectedItem as Cliente;
   
    Application.Current.MainPage = page;
  }
    }


}
