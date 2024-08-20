using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.fluxo
{
    public partial class ClientesPage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public ClientesPage()
        {
            InitializeComponent();



        }

        void CadastrarClienteClicked(object sender, EventArgs e)
        {
            var cliente = new Modelos.Cliente();
            cliente.Nome = NomeEntry.Text;
            cliente.Endereço = EnderecoEntry.Text;
            cliente.CPF = CPFEntry.Text;
            cliente.Email =EmailEntry.Text;

            
            clienteControle.CriarOuAtualizar(cliente);
        }
    }


}
