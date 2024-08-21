using Modelos;

namespace trabalho.fluxo
{
    public partial class ListaClientePage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public ListaClientePage()
        {
            InitializeComponent();



        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaClientes.ItemsSource = clienteControle.LerTodos();
        }
        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new ClientesPage();

            page.cliente = e.SelectedItem as Cliente;

            Application.Current.MainPage = page;
        }



        async void OnClientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());
        }

    }
}