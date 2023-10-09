using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeReglementFournisseurDetail
{
    public string NumeroReglementFournisseur { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public decimal TotalBrute { get; set; }

    public decimal TotalRetenu { get; set; }

    public decimal TotalNet { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string ModeReglement { get; set; } = null!;

    public string Compte { get; set; } = null!;
}
