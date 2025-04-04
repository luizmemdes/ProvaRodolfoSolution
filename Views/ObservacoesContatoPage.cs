using Microsoft.Maui;
using ObjCRuntime;
using static System.Net.Mime.MediaTypeNames;

using System.Xml.Linq;

<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             x: Class = "ProvaRodolfo.Views.ObservacoesContatoPage"
             Title = "Observações do Contato" >

    < VerticalStackLayout Padding = "10" Spacing = "10" >
        < Label Text = "Observações" FontSize = "20" />
        < Editor x: Name = "editorObservacao"
                HeightRequest = "150"
                Placeholder = "Digite aqui a observação..." />
        < Button Text = "Salvar" Clicked = "OnSalvarClicked" />
        < Button Text = "Cancelar" Clicked = "OnCancelarClicked" />
    </ VerticalStackLayout >
</ ContentPage >
