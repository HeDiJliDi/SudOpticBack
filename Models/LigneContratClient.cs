using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneContratClient
{
    public string NumeroContratClient { get; set; } = null!;

    public int NumeroQuittance { get; set; }

    public string CodeClient { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public DateTime DateQuittance { get; set; }

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public decimal MontantHt { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string DateFacturation { get; set; } = null!;
}
