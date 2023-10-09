using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ListeBlBr
{
    public string RaisonSociale { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;

    public DateTime DatePiece { get; set; }

    public string NumeroPiece { get; set; } = null!;

    public string NumeroBl { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalTtc { get; set; }
}
