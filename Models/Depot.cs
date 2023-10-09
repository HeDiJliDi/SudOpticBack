using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Depot
{
    public string CodeDepot { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public bool EtatInventaire { get; set; }

    public int NumeroOrdre { get; set; }

    public bool PersonnePhysique { get; set; }
}
