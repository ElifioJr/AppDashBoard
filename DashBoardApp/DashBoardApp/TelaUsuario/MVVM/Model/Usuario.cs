

using SQLite;

namespace DashBoardApp.TelaUsuario.MVVM.Model;

[Table("Usuario")]
public class Usuario
    {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Nome { get; set; }

    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(100)]
    public string Senha { get; set; }

    }

