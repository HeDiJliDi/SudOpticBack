using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class AvoirVente
{
    public string NumeroAvoirVente { get; set; } = null!;

    public string NumeroFactureVente { get; set; } = null!;

    public DateTime DateAvoirVente { get; set; }

    public string CodeClient { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TimbreFiscal { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public decimal TotalRemise { get; set; }

    public string NumeroExportation { get; set; } = null!;

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public decimal TotalAvanceImpot { get; set; }
}
