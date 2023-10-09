using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FournisseurArticle
{
    public string CodeArticle { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public decimal DernierPrixAchat { get; set; }

    public decimal TauxRemise { get; set; }

    public string CodeArticleFournisseur { get; set; } = null!;
}
