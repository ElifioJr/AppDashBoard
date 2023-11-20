using CommunityToolkit.Maui;
using DashBoardApp.TelaUsuario.MVVM.View;
using DashBoardApp.TelaUsuario.MVVM.ViewModel;
using DashBoardApp.TelaUsuario.Services;
using Microsoft.Extensions.Logging;

namespace DashBoardApp
    {
    public static class MauiProgram
        {
        public static MauiApp CreateMauiApp()
            {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            // Views TelaUsuario
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<CadastroPage>();

            //ViewModel TelaUsuario
            builder.Services.AddTransient<CadastroPageViewModel>();
            builder.Services.AddTransient<LoginPageViewModel>();
            //Service Tela Usuario
            builder.Services.AddTransient<IUsuarioService, UsuarioService>();


            return builder.Build();
            }
        }
    }