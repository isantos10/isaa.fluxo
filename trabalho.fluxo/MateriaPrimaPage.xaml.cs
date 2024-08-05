using Microsoft.Maui.Controls;

namespace trabalho.fluxo
{
    public partial class MateriaPrimaPage: ContentPage
    {
        public MateriaPrimaPage()
        {
            InitializeComponent();
        }
         private void OnEnviarClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Enviado", "Dados enviados com sucesso!", "OK");
        }
    }
}