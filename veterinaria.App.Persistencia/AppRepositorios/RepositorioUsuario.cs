using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;
namespace veterinaria.App.Persistencia

{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Referencia al contexto de Usuario
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza
        ///Inyeccion de dependencias para indicar el contecto a utilizar
        /// </summary>  
        ///<param name="appContext"></param>//
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;

        }

        Usuario IRepositorioUsuario.AddUsuario(Usuario usuaio)
        {
            var usuarioAdicionado = _appContext.Usuario.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u => u.Id == idUsuario);
            if (usuarioEncontrado == null)
                return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios()
        {
            return _appContext.Usuarios;
        }
        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.FirstOrDefault(u => u.Id == idUsuario);
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Nombre = usuario.Nombre;
                usuarioEncontrado.Apellido = usuario.Apellido;
                usuarioEncontrado.NumeroTelefono = usuario.NumeroTelefono;
                usuarioEncontrado.Genero = usuario.Genero;
                usuarioEncontrado.Direccion = usuario.Direccion;
                usuarioEncontrado.Latitud = usuario.Latitud;
                usuarioEncontrado.Longitud = usuario.Longitud;
                usuarioEncontrado.Ciudad = usuario.Ciudad;
                usuarioEncontrado.FechaNacimiento = usuario.FechaNacimiento;
                usuarioEncontrado.Familiar = usuario.Familiar;
                usuarioEncontrado.Enfermera = usuario.Enfermera;
                usuarioEncontrado.Medico = usuario.Medico;
                usuarioEncontrado.Historia = usuario.Historia;

                _appContext.SaveChanges();
                
            }
            return usuarioEncontrado;

        }



    }


}
