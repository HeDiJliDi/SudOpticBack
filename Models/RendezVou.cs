using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class RendezVou
{
    public string NumeroRdv { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public DateTime DateRdv { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeTypeVisite { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }
}
