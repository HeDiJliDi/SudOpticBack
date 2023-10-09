using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FactureExport
{
    public string NumeroFactureExport { get; set; } = null!;

    public DateTime DateFactureExport { get; set; }

    public string? NumeroPrefacture { get; set; }

    public string CodeClient { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TimbreFiscal { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroFactureVente { get; set; } = null!;

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

    public decimal BaseAvanceImpot { get; set; }

    public decimal TotalAvanceImpot { get; set; }

    public string? CodeDevise { get; set; }

    public decimal Nbcolis { get; set; }

    public decimal PoidsBrut { get; set; }

    public decimal PoidsNet { get; set; }

    public string TypeTransport { get; set; } = null!;

    public string Assurance { get; set; } = null!;

    public string Cl { get; set; } = null!;

    public string NotreBanque { get; set; } = null!;

    public string Iban { get; set; } = null!;

    public string Bic { get; set; } = null!;

    public decimal? QuantiteCarton { get; set; }

    public string? Incoterme { get; set; }

    public decimal? ChangementDevise { get; set; }

    public string AdresseFrontiere { get; set; } = null!;

    public string NumeroOrdre { get; set; } = null!;

    public decimal Commission { get; set; }

    public decimal Deposit { get; set; }

    public bool CalculMontantDevise { get; set; }

    public string Vehicule { get; set; } = null!;

    public string Tracteur { get; set; } = null!;

    public string Remorque { get; set; } = null!;
}
