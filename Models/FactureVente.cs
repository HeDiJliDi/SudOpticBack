using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FactureVente
{
    public string NumeroFactureVente { get; set; } = null!;

    public DateTime DateFactureVente { get; set; }

    public string CodeDepot { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

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

    public DateTime DateEcheance { get; set; }

    public string ReglementFacture { get; set; } = null!;

    public string Conditions { get; set; } = null!;

    public string NumeroExportation { get; set; } = null!;

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public decimal TotalAvanceImpot { get; set; }
}
