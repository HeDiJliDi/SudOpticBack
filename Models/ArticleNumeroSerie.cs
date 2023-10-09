using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ArticleNumeroSerie
{
    public string CodeArticle { get; set; } = null!;

    public string NumeroSerie { get; set; } = null!;

    public string NumeroInventaire { get; set; } = null!;

    public string NumeroBonLivraisonAchat { get; set; } = null!;

    public string NumeroBonLivraisonVente { get; set; } = null!;

    public string NumeroBonRetourAchat { get; set; } = null!;

    public string NumeroBonRetourVente { get; set; } = null!;

    public string NumeroFactureAchat { get; set; } = null!;

    public string NumeroFactureVente { get; set; } = null!;

    public string NumeroAvoirAchat { get; set; } = null!;

    public string NumeroAvoirVente { get; set; } = null!;

    public string NumeroBonEntrer { get; set; } = null!;

    public string NumeroBonSortie { get; set; } = null!;

    public string NumeroPieceAchat { get; set; } = null!;

    public string NumeroPieceVente { get; set; } = null!;

    public string NumeroEtat { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public bool Choix { get; set; }
}
