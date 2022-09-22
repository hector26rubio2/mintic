using System.Collections.Generic;
using veterinaria.App.Dominio;

namespace veterinaria.App.Persistencia
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