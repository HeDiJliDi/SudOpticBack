using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonCommandeVente
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public DateTime DateBonCommandeVente { get; set; }

    public string NumeroDevisVente { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string ReferenceClient { get; set; } = null!;

    public DateTime DateReferenceClient { get; set; }

    public decimal DelaiLivraison { get; set; }

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public string CodeTypeVente { get; set; } = null!;

    public bool Consulter { get; set; }
}
