using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ArticleTerminal
{
    public decimal Numero { get; set; }

    public string CodeArticle { get; set; } = null!;

    public decimal Quantite { get; set; }

    public bool Importer { get; set; }
}
