
using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;
using veterinaria.App.Persistencia;

namespace veterinaria.App.Persistencia
{
    public class RepositorioRecomendacion : IRepositorioRecomendacion

    {
        ///<summary>
        /// referencias de la recomendacion
        ///</summary>
        private readonly AppContext _appContext;

  

        ///<summary>
        /// metodo constructor utiliza 
        /// inyeccion de dependencias para indicar el contextos a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioRecomendacion(AppContext appContext)
        {
            _appContext = appContext;
        }

        Recomendacion IRepositorioRecomendacion.AddRecomendaion(Recomendacion recomendacion)
        {
            var recomendacionNueva = _appContext.Recomendacion.Add(recomendacion);
            _appContext.SaveChanges();
            return recomendacionNueva.Entity;

        }

        Recomendacion IRepositorioRecomendacion.DeleteRecomendacion(string codigo)
        {
            var recomendacionEncontrado = _appContext.Recomendacion.FirstOrDefault(r => r.Codigo == codigo);
            if (recomendacionEncontrado == null)
                return;

            _appContext.Recomendacion.Remove(recomendacionEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Recomendacion> IRepositorioRecomendacion.GetAllRecomendacion()
        {

            return _appContext.Recomendacion;

        }


        Recomendacion IRepositorioRecomendacion.GetRecomendacion(string codigo)
        {
            return _appContext.Recomendacion.FirstOrDefault(r => r.Codigo == codigo);

        }

        Recomendacion IRepositorioRecomendacion.UpdateRecomendacion(Recomendacion recomendacion)
        {
            var recomendacionEncontrado = _appContext.Recomendacion.FirstOrDefault(r => r.Codigo == codigo);
            if (recomendacionEncontrado != null)
            {
                recomendacionEncontrado.NotasRecomendacion = recomendacion.NotasRecomendacion;
                recomendacionEncontrado.Medicamentos = recomendacion.Medicamentos;
                recomendacionEncontrado.Veterinaria = recomendacion.Veterinaria;
                _appContext.SaveChanges();
            }

            return recomendacionEncontrado;

        }
    }
}