using System;
namespace veterinaria.App.Dominio;
public class Mascota
{

    public String Nombre { get; set; }
    public String Color { get; set; }
    public String Raza { get; set; }
    public String Especie { get; set; }
    public Historial Historial { get; set; }

}
