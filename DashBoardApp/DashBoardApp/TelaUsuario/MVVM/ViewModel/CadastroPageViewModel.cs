using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DashBoardApp.TelaUsuario.Services;
using DashBoardApp.TelaUsuario.MVVM.Model;

namespace DashBoardApp.TelaUsuario.MVVM.ViewModel;

public partial class CadastroPageViewModel : ObservableObject
    {
    private readonly IUsuarioService _usuarioService;

    [ObservableProperty]
    private string _usuarioNome;
    [ObservableProperty]
    private string _usuarioEmail;
    [ObservableProperty]
    private string _usuarioSenha;


    public CadastroPageViewModel(IUsuarioService usuarioService)
        {
        _usuarioService = usuarioService;
        }

    [RelayCommand]
    private async Task AddUsuario() 
        {
        try
            {
            if (!string.IsNullOrEmpty(UsuarioNome))
                {
                Usuario usuario = new()
                    {
                    Nome = UsuarioNome,
                    Email = UsuarioEmail,
                    Senha = UsuarioSenha
                    };
                await _usuarioService.InitializeAsync();
                await _usuarioService.CriaUsuarioAsync(usuario);
                await Shell.Current.GoToAsync("..");
                }

            else
                {
                await Shell.Current.DisplayAlert("Error", "Usuario sem Nome", "OK");
                }
            }
        catch(Exception ex) 
            {
                await Shell.Current.DisplayAlert("Error",ex.Message, "OK");
            };
              
        }

    }

