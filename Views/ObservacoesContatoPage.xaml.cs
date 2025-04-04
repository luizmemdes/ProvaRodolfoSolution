using Microsoft.Maui.Controls;
using System;

namespace ProvaRodolfo.Views
{
    public partial class ObservacoesContatoPage : ContentPage
    {
        public ObservacoesContatoPage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Salvo", "Observação salva com sucesso!", "OK");
            await Navigation.PopAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
