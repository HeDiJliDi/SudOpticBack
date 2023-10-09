using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Utilisateur
{
    public string NomUtilisateur { get; set; } = null!;

    public string CodeSociete { get; set; } = null!;

    public string CodeFonction { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public bool? Actif { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public decimal PlafondTauxRemiseVente { get; set; }

    public string CodeDepot { get; set; } = null!;

    public bool ForcageBonCommande { get; set; }
}
