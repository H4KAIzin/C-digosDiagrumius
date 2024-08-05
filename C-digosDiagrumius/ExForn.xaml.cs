using Microsoft.Maui.Controls;

namespace CdigosDiagrumius
{
    public partial class ExForn : ContentPage
    {
        public bool IsPopupVisible { get; set; } = false;

        public ExForn()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
