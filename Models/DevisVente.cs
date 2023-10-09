using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class DevisVente
{
    public string NumeroDevisVente { get; set; } = null!;

    public DateTime DateDevisVente { get; set; }

    public string CodeClient { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TimbreFiscal { get; set; }

    public decimal TotalTtc { get; set; }

    public string? NumeroFactureVente { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string Vref { get; set; } = null!;

    public string ConditionVente { get; set; } = null!;

    public string ModeDeReglment { get; set; } = null!;

    public string ConditionReglement { get; set; } = null!;

    public string DelaiLivraison { get; set; } = null!;

    public string ValiditeOffre { get; set; } = null!;

    public string AttentionDe { get; set; } = null!;
}
