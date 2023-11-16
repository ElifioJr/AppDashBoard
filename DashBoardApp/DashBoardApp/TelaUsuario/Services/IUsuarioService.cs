using DashBoardApp.TelaUsuario.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardApp.TelaUsuario.Services;

public  interface IUsuarioService
    {
    Task InitializeAsync();
    Task<IEnumerable<Usuario>> GetUsuarioAsync();
    Task<IEnumerable<Usuario>> GetNomeUsuarioAsync(string nome);
    Task<int> CriaUsuarioAsync(Usuario usuario);
    Task<int> DeletaUsuarioAsync(Usuario usuario);
    Task<int> AtualizaUsuarioAsync(Usuario usuario);
    }

