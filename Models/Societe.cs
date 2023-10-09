using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Societe
{
    public string CodeSociete { get; set; } = null!;

    public string CodeForme { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string Responsable { get; set; } = null!;

    public string MatriculeFiscale { get; set; } = null!;

    public string RegistreCommerce { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string RibBanquaire { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string CodePostal { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Pays { get; set; } = null!;

    public string Tel1 { get; set; } = null!;

    public string Tel2 { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;

    public byte[]? Logo { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeCnam { get; set; } = null!;
}
