using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;
using veterinaria.App.Persistencia;

namespace veterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
            ///<summary>
        /// referencias de la empresa
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        /// metodo constructor utiliza 
        /// inyeccion de dependencias para indicar el contextos a utilizar
        ///</summary>
        ///<param name="appContext"></param>//  
    
        public RepositorioMascota (AppContext appContext)
        {
            _appContext = appContext;
        }


        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionada= _appContext.Mascota.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        
         void IRepositorioMascota.DeleteMascota(string Nombre)
         {
            var mascotaEncontrada=_appContext.mascota.FirstOrDefault (m => m.Nombre=nombre);
            if (mascotaEncontrada== null)
                return;
            _appContext.Mascota.Remove(mascotaEncontrada);
            _appContext.SaveChanges();
         }
        

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascota()
        {

            return _appContext.Mascota;
        }


        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrada = _appContext.Mascota.FirstOrDefault(m => m.Nombre == nombre);
            if (mascotaEncontrada != null){
                mascotaEncontrada.Color=mascota.Color;
                mascotaEncontrada.Raza=mascota.Raza;
                mascotaEncontrada.Especie=mascota.Especie;
                mascotaEncontrada.Historial=mascota.Historial;
                
                _appContext.SaveChanges();

            }
            return mascotaEncontrada;
        }    
    }
}