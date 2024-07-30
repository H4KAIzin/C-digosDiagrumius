using Microsoft.Maui.Controls;

namespace CdigosDiagrumius
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            // Aqui você pode adicionar a lógica de autenticação
            // Por exemplo, você pode validar as credenciais e navegar para outra página

            DisplayAlert("Login", $"E-mail: {email}\nSenha: {password}", "OK");
        }
    }
}
