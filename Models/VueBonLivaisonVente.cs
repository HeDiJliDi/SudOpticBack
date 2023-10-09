using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueBonLivaisonVente
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public DateTime DateBonLivraisonVente { get; set; }

    public string CodeClient { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string NomPrenomLivreur { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal? Nbpiece { get; set; }

    public decimal TotalTtc { get; set; }

    public string CodeTypeVente { get; set; } = null!;

    public string Numeroetat { get; set; } = null!;

    public string? RaisonSociale { get; set; }
}
