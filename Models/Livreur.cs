using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Livreur
{
    public string CodeLivreur { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;

    public string Cin { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string RibBanquaire { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string CodePostal { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Pays { get; set; } = null!;

    public string Tel1 { get; set; } = null!;

    public string Tel2 { get; set; } = null!;

    public string Assistant { get; set; } = null!;

    public string Cinassistant { get; set; } = null!;

    public string Observation { get; set; } = null!;

    public string CodeCompte { get; set; } = null!;

    public bool ExceptionDebloquage { get; set; }

    public bool? Actif { get; set; }

    public string CodeDepot { get; set; } = null!;

    public string CodeCamion { get; set; } = null!;

    public decimal TauxCommission { get; set; }
}
