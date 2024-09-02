using Modelos;

namespace trabalho.fluxo
{
    public partial class ListaCostureiraPage : ContentPage
    {
        Controles.CostureiraControle costureiraControle = new Controles.CostureiraControle();

        public ListaCostureiraPage()
        {
            InitializeComponent();



        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaCostureira.ItemsSource = costureiraControle.LerTodos();
        }
        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CostureiraPage();

            page.costureira = e.SelectedItem as Costureira;

            Application.Current.MainPage = page;
        }



        async void OnCostureiraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CostureiraPage());
        }

    }
}