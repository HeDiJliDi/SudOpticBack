using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeArticleFournisseur
{
    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal PrixAchatHt { get; set; }

    public string CodeTva { get; set; } = null!;

    public bool Fodec { get; set; }

    public bool Stockable { get; set; }

    public bool Actif { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public decimal DernierPrixAchat { get; set; }

    public decimal TauxRemise { get; set; }

    public string CodeArticleFournisseur { get; set; } = null!;
}
