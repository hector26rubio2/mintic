using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;
using veterinaria.App.Dominio;
namespace veterinaria.App.Persistencia

{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        /// <summary>
        /// Referencia al contexto de Veterinario
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza
        ///Inyeccion de dependencias para indicar el contecto a utilizar
        /// </summary>  
        ///<param name="appContext"></param>//
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;

        }

        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinario.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        void IRepositorioveterinario.DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.veterinario.FirstOrDefault(v => v.Id == idVeterinario);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinario.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
        {
            return _appContext.Veterinario;
        }
        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinario.FirstOrDefault(v => v.Id == idVeterinario);
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinario.FirstOrDefault(v => v.Id == veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombre = veterinario.Nombre;
                veterinarioEncontrado.Apellido = veterinario.Apellido;
                veterinarioEncontrado.NumeroTelefono = veterinario.NumeroTelefono;
                veterinarioEncontrado.Genero = veterinario.Genero;
                veterinarioEncontrado.Direccion = veterinario.Direccion;
                veterinarioEncontrado.Latitud = veterinario.Latitud;
                veterinarioEncontrado.Longitud = veterinario.Longitud;
                veterinarioEncontrado.Ciudad = veterinario.Ciudad;
                veterinarioEncontrado.FechaNacimiento = veterinario.FechaNacimiento;
                veterinarioEncontrado.Familiar = veterinario.Familiar;
                veterinarioEncontrado.Enfermera = veterinario.Enfermera;
                veterinarioEncontrado.Medico = veterinario.Medico;
                veterinarioEncontrado.Historia = veterinario.Historia;

                _appContext.SaveChanges();
                
            }
            return veterinarioEncontrado;

        }



    }


}
