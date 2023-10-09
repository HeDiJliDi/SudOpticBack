using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonLivraisonVente
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public DateTime DateBonLivraisonVente { get; set; }

    public string NumeroBonCommandeVente { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NumeroFactureVente { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string ReferenceBonCommande { get; set; } = null!;

    public string NumeroExportation { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string CodeCamion { get; set; } = null!;

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public string CodeTypeVente { get; set; } = null!;

    public DateTime DateCommande { get; set; }

    public string NomValideur { get; set; } = null!;

    public DateTime DateValidation { get; set; }

    public bool Valider { get; set; }

    public DateTime DateLivraison { get; set; }

    public decimal TotalRecu { get; set; }

    public string ObservationInterne { get; set; } = null!;
}
