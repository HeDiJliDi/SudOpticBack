using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeArticleAngular
{
    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string CodeCouleur { get; set; } = null!;

    public decimal? Qtglobal { get; set; }

    public decimal Qtreserver { get; set; }

    public decimal Qtmagsin { get; set; }
}
