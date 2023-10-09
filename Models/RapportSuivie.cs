using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class RapportSuivie
{
    public string NumeroRapportSuivie { get; set; } = null!;

    public DateTime DateRapportSuivie { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string CodeTypeVisite { get; set; } = null!;
}
