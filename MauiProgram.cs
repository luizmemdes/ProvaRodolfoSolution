using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ProvaRodolfo.Views;
using CasosDeUso.Interface;
using CasosDeUso;
using Plugins.SqlLite;

namespace ProvaRodolfo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>() 
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            
            builder.Services.AddSingleton<IEditarContatoUseCase, EditarContatoUseCase>();
            builder.Services.AddSingleton<IRepositorioDeContatos, RepositorioContatosSqlLite>();
            builder.Services.AddSingleton<ObservacoesContatoPage>();

            return builder.Build();
        }
    }
}
