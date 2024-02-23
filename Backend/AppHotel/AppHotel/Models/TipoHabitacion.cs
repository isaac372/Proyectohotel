using System;
using System.Collections.Generic;

namespace AppHotel.Models;

public partial class TipoHabitacion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Imagen { get; set; } = null!;

    public int IdHotel { get; set; }

    public int? Cantidad { get; set; }

    public virtual Hotel IdHotelNavigation { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
