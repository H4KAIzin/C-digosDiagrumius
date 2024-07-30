using Microsoft.Maui.Controls;

namespace CdigosDiagrumius
{
    public partial class ExcluirPerfil : ContentPage
    {
        public ExcluirPerfil()
        {
            InitializeComponent();
        }

        private async void Sim_Clicked(object sender, EventArgs e)
        {
            // Lógica para excluir o perfil
            await DisplayAlert("Confirmação", "Perfil excluído com sucesso.", "OK");
            // Navegar para outra página ou realizar outras ações
        }

        private void Nao_Clicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a exclusão
            Navigation.PopAsync(); // Voltar para a página anterior
        }
    }
}
