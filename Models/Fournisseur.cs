using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Fournisseur
{
    public string CodeFournisseur { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string CodeForme { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string Responsable { get; set; } = null!;

    public string MatriculeFiscale { get; set; } = null!;

    public string RegistreCommerce { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string RibBanquaire { get; set; } = null!;

    public string Adresse1 { get; set; } = null!;

    public string CodePostal1 { get; set; } = null!;

    public string Ville1 { get; set; } = null!;

    public string Pays1 { get; set; } = null!;

    public string Tel1 { get; set; } = null!;

    public string Fax1 { get; set; } = null!;

    public string Adresse2 { get; set; } = null!;

    public string CodePostal2 { get; set; } = null!;

    public string Ville2 { get; set; } = null!;

    public string Pays2 { get; set; } = null!;

    public string Tel2 { get; set; } = null!;

    public string Fax2 { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;

    public bool Exoneration { get; set; }

    public string NumeroExoneration { get; set; } = null!;

    public DateTime? DateDebutExoneration { get; set; }

    public DateTime? DateFinExoneration { get; set; }

    public bool? PayerTva { get; set; }

    public bool? Assujetti { get; set; }

    public bool Fodec { get; set; }

    public bool Export { get; set; }

    public bool? TimbreFiscal { get; set; }

    public string Observation { get; set; } = null!;

    public bool? SolderFiche { get; set; }

    public string CodeComptable { get; set; } = null!;

    public bool FournisseurDepence { get; set; }

    public string CompteComptable { get; set; } = null!;

    public string CompteAchat { get; set; } = null!;
}
