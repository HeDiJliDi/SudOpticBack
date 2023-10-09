using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonLivraisonAchat
{
    public string NumeroBonLivraisonAchat { get; set; } = null!;

    public DateTime DateBonLivraisonAchat { get; set; }

    public string NumeroBonCommandeAchat { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string ReferenceFournisseur { get; set; } = null!;

    public DateTime? DateReferenceFournisseur { get; set; }

    public string CodeDepot { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NumeroFactureAchat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string NumeroExportation { get; set; } = null!;

    public int Nbimpression { get; set; }

    public int Nbvalise { get; set; }

    public decimal TauxDeChange { get; set; }

    public string Devise { get; set; } = null!;

    public bool? Bldevise { get; set; }

    public decimal FraisTransport { get; set; }
}
