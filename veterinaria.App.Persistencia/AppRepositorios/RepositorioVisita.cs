using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using veterinaria.App.Persistencia;
using veterinaria.App.Dominio;

namespace FrecuenciaCardiaca.App.Persistencia

{
    public class RepositorioVisita : IRepositorioVsitia
    {

        ///<summary>
        /// referencias de la visita
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        /// metodo constructor utiliza cls
        /// inyeccion de dependencias para indicar el contextos a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        }

        Visita IRepositorioVisita.AddRecomendaion(Visita visita)
        {
            var visitaNueva = _appContext.Visita.Add(visita);
            _appContext.SaveChanges();
            return visitaNueva.Entity;

        }

        Visita IRepositorioVisita.DeleteVisita(string codigo)
        {
            var visitaEncontrado = _appContext.Visita.FirstOrDefault(r => r.Codigo == codigo);
            if (visitaEncontrado == null)
                return;

            _appContext.Visita.Remove(visitaEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Visita> IRepositorioVisita.GetAllVisita()
        {

            return _appContext.Visita;

        }


        Visita IRepositorioVisita.GetVisita(string codigo)
        {
            return _appContext.Visita.FirstOrDefault(r => r.Codigo == codigo);

        }

        Visita IRepositorioVisita.UpdateVisita(Visita visita)
        {
            var visitaEncontrado = _appContext.Visita.FirstOrDefault(r => r.Codigo == codigo);
            if (visitaEncontrado != null)
            {
                visitaEncontrado.Temperatura = visita.Temperatura;
                visitaEncontrado.Peso = visita.Peso;
                visitaEncontrado.FrecuenciaCardiaca = visita.FrecuenciaCardiaca;
                visitaEncontrado.FrecuenciaRespratoria = visita.FrecuenciaRespratoria;
                visitaEncontrado.EstadoDeAnimo = visita.EstadoDeAnimo;
                visitaEncontrado.FechaVisita = visita.FechaVisita;
                visitaEncontrado.Veterinario = visita.Veterinario;
                visitaEncontrado.Recomendaiones = visita.Recomendaiones;
                _appContext.SaveChanges();
            }

            return visitaEncontrado;

        }
    }
}
