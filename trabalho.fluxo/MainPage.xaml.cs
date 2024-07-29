namespace trabalho.fluxo;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

        async void OnCadastrarFornecedorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarFornecedorPage());
        }

        async void OnCadastrarMateriaPrimaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MateriaPrimaPage());
        }

        async void OnGerenciarVendasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GerenciarVendasPage());

        async void ClientesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());
        }
        async void AcomVendasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AcompanharVendasPage());
        }

        async void OnCadastrarCostureiraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarCostureiraPage());
        }
}
}