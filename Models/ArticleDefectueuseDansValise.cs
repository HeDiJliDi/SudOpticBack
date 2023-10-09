using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ArticleDefectueuseDansValise
{
    public string NumeroBonCommande { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public string Designation { get; set; } = null!;

    public decimal Quantite { get; set; }

    public string CodeCause { get; set; } = null!;

    public string LibelleCause { get; set; } = null!;

    public bool Valider { get; set; }

    public bool Cloturer { get; set; }

    public bool Annuler { get; set; }
}
