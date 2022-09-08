
using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;
using veterinaria.App.Persistencia;

namespace veterinaria.App.Persistencia
{
     public class RepositorioEmpresa : IRespositorioEmpresa
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

        public RepositorioEmpresa(AppContext appContext)
        {
            _appContext = appContext;
        }

        Empresa IRepositorioEmpresa.AddEmpresa(Empresa empresa)
        {
            var empresaNueva = _appContext.Empresa.Add(empresa);
            _appContext.SaveChanges();
            return empresaNueva.Entity;

        }

        Empresa IRepositorioEmpresa.DeleteEmpresa(string IdEmpresa)
        {
            var empresaEncontrada = _appContext.Empresa.FirstOrDefault(e => e.IdEmpresa == IdEmpresa);
            if (empresaEncontrada == null)
                return;

            _appContext.Empresa.Remove(empresaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Empresa> IRepositorioEmpresa.GetAllEmpresa()
        {

            return _appContext.Empresa;

        }

         Empresa IRepositorioEmpresa.GetEmpresa(string IdEmpresa)
        {
            return _appContext.Empresa.FirstOrDefault(e => e.IdEmpresa == IdEmpresa);

        }

        Empresa IRepositorioEmpresa.UpdateEmpresa(Empresa empresa)
        {
            var empresaEncontrada = _appContext.Empresa.FirstOrDefault(e => e.IdEmpresa == IdEmpresa);
            if (empresaEncontrada != null)
            {
                empresaEncontrada.veterinarios = empresa.veterinarios;
                 empresaEncontrada.clientes = empresa.clientes;                 
                _appContext.SaveChanges();
            }

            return empresaEncontrada;

        }


     }
}