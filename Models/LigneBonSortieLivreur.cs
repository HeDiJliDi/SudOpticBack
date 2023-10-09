using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneBonSortieLivreur
{
    public string NumeroBonSortieLivreur { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public string Designation { get; set; } = null!;

    public decimal PrixVenteHt { get; set; }

    public decimal Quantite { get; set; }

    public decimal MontantHt { get; set; }

    public decimal TauxRemise { get; set; }

    public decimal MontantRemise { get; set; }

    public decimal MontantFodec { get; set; }

    public decimal NetHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public string Observation { get; set; } = null!;

    public decimal PrixAchatNet { get; set; }

    public decimal PrixUniteTtc { get; set; }

    public int NumeroMaj { get; set; }

    public DateTime DateMaj { get; set; }
}
