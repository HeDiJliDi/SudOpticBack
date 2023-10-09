using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FraisPrixExport
{
    public string NumeroPiece { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public decimal TauxEchange { get; set; }

    public decimal FraisTransport { get; set; }

    public decimal FraisDouane { get; set; }

    public decimal Frais3 { get; set; }

    public decimal TauxFraisTransport { get; set; }

    public decimal TauxFraisDouane { get; set; }

    public decimal TauxFrais3 { get; set; }

    public decimal PrixEnDevise { get; set; }

    public decimal PrixGlobal { get; set; }

    public decimal PoidsGlobal { get; set; }

    public DateTime DatePiece { get; set; }
}
