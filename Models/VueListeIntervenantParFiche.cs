using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeIntervenantParFiche
{
    public string NumeroFicheIntervention { get; set; } = null!;

    public string CodeIntervenant { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;
}
