using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FactureAchatDiver
{
    public string NumeroAchatDiver { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public DateTime DateAchatDiver { get; set; }

    public string ReferenceFournisseur { get; set; } = null!;

    public DateTime DateReferenceFournisseur { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TimbreFiscal { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;
}
