using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueMouvementCompte
{
    public string NumeroMouvement { get; set; } = null!;

    public DateTime DateMouvement { get; set; }

    public string Libelle { get; set; } = null!;

    public string TypeMouvement { get; set; } = null!;

    public string CodeCompte { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public decimal Montant { get; set; }

    public string Observation { get; set; } = null!;

    public DateTime? Echeance { get; set; }

    public string? NomUtilisateur { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string? NumeroEtat { get; set; }

    public string? RaisonSociale { get; set; }

    public string? Etat { get; set; }

    public string Compte { get; set; } = null!;
}
