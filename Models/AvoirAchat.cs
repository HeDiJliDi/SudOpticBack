using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class AvoirAchat
{
    public string NumeroAvoirAchat { get; set; } = null!;

    public string NumeroFactureAchat { get; set; } = null!;

    public DateTime DateAvoirAchat { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string ReferenceFournisseur { get; set; } = null!;

    public DateTime DateRefrenceFournisseur { get; set; }

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

    public string NumeroExportation { get; set; } = null!;
}
