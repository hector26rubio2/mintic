using System.Collections.Generic;
using System;
using VETERINARIA.APP.DOMINIO;
using VETERINARIA.APP.PERSISTENCIA;

namespace VETERINARIA.APP.CONSOLE
{
    private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario(new Persistencia.AppContext());
    static void Main(string[] args)
    
    {
    
     Console.WriteLine("Hello, World!");
     //AddUsuario();
     BuscarUsuario(1);
 
    } 
    private static void AddUsuario()

    {

        var usuario = new Usuario();
      /* {

        Nombre = "Nicolay",
        Apellido = "Perez",
        NumeroTeléfono = "3001645",
        Genero = Genero.Masculino,
        Direccion = "Calle 4 No. 7 - 4",
        Longitud = 5.076,
        Latitud = 75.522,
        Ciudad = "Manizales",
        FechaNacimiento = new DateTime(1990, 04, 12);
        
        };
*/
    _repoUsuario.AddUsuario(usuario);
    
    }
    private static void BuscarUsuario(int idUsuario)
    {
        var usuario = _repoUsuario.GetUsuario(idUsuario);
        Console.WriteLine(usuario.Nombre+" "+usuario.Apellido);
    }
}