using DashBoardApp.TelaUsuario.MVVM.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DashBoardApp.TelaUsuario.MVVM.Model.Usuario;

namespace DashBoardApp.TelaUsuario.Services;

public class UsuarioService : IUsuarioService
    {

    private SQLiteAsyncConnection _dbConnection;


    public async Task<int> AtualizaUsuarioAsync(Usuario usuario)
        {
            return await _dbConnection.UpdateAsync(usuario);
        }

    public async Task<int> CriaUsuarioAsync(Usuario usuario)
        {
            return await _dbConnection.InsertAsync(usuario);
        }

    public async Task<int> DeletaUsuarioAsync(Usuario Id)
        {
            return await _dbConnection.DeleteAsync(Id);
        }




// Conexao Com o banco de dados
    public async Task InitializeAsync()
        {
        await SetUpDb();
        }
    private async Task SetUpDb()
        {
        if (_dbConnection == null)
            {
            string dbPath = Path.Combine(Environment.
                GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UsuariosDB.db3");
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<Usuario>();
            }
        }
    }

