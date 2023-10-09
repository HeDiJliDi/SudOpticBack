using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeAfacturer
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public DateTime DateBonLivraisonVente { get; set; }

    public string CodeClient { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string MatriculeFiscale { get; set; } = null!;

    public decimal? TotalHt { get; set; }

    public decimal? TotalRemise { get; set; }

    public decimal? TotalNetHt { get; set; }

    public decimal? TotalTva { get; set; }

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal? MontantRemiseExceptionnel { get; set; }

    public decimal? TotalTtc { get; set; }
}
