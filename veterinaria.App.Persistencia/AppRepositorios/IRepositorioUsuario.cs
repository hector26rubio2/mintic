using System.Collections.Generic;

namespace veterinaria.App.Persistence.AppRepositorios
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuarios();

        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
    void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);

    }

}