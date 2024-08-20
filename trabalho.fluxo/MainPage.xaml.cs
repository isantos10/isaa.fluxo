namespace trabalho.fluxo;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

        async void OnFornecedorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FornecedorPage());
        }

        async void OnCadastrarMateriaPrimaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MateriaPrimaPage());
        }

        async void OnVendasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VendasPage());
        }
        async void ClientesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaClientePage());
        }

        async void OnCostureiraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CostureiraPage());
        }

}