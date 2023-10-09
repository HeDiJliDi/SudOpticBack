using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueSuivieBonCommande
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public decimal QteCommandee { get; set; }

    public decimal? QteLivree { get; set; }

    public decimal? QteRestante { get; set; }

    public decimal QuantiteStock { get; set; }

    public decimal? QuantitePossible { get; set; }

    public DateTime DateBonCommandeVente { get; set; }

    public string Libelle { get; set; } = null!;

    public string NumeroEtat { get; set; } = null!;

    public string Expr1 { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public decimal PrixVenteHt { get; set; }

    public decimal MontantHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public string Observation { get; set; } = null!;

    public decimal TauxRemise { get; set; }

    public decimal? MontantRemise { get; set; }

    public decimal? MontantFodec { get; set; }

    public decimal? NetHt { get; set; }

    public decimal PrixAchatNet { get; set; }

    public string ReferenceClient { get; set; } = null!;
}
