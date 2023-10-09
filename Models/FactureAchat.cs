using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FactureAchat
{
    public string NumeroFactureAchat { get; set; } = null!;

    public DateTime DateFactureAchat { get; set; }

    public string CodeDepot { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string ReferenceFournisseur { get; set; } = null!;

    public DateTime DateReferenceFournisseur { get; set; }

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

    public string NumeroExportation { get; set; } = null!;

    public decimal Douane { get; set; }

    public decimal Fret { get; set; }

    public decimal TransportLocal { get; set; }

    public decimal Assurence { get; set; }

    public decimal FraisTransit { get; set; }

    public decimal AutreFrais { get; set; }

    public decimal TauxChange { get; set; }

    public decimal CoutChange { get; set; }

    public decimal TotalFrais { get; set; }

    public decimal TotalAchatDevis { get; set; }

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public decimal TotalFraisTransportEnDevise { get; set; }
}
