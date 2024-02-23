using System;
using System.Collections.Generic;

namespace AppHotel.Models;

public partial class Reserva
{
    public int Id { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public decimal Precio { get; set; }

    public int? IdCliente { get; set; }

    public int? IdTipoHabitacion { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; }

    public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; }

    public Reserva()
    {
        IdClienteNavigation = new Cliente { Apellido = "", Nombre = "", Telefono = "" };
        IdTipoHabitacionNavigation = new TipoHabitacion
        {
            Imagen = "",
            Descripcion = "",
            IdHotelNavigation = new Hotel { Descripcion = "", Nombre = "" }
        };
    }
}
