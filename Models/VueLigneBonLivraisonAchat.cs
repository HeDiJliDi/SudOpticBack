using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneBonLivraisonAchat
{
    public bool Choix { get; set; }

    public decimal? PuenDevise { get; set; }

    public string NumeroBonLivraisonAchat { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal PrixAchatHt { get; set; }

    public decimal Quantite { get; set; }

    public decimal MontantHt { get; set; }

    public decimal TauxRemise { get; set; }

    public decimal MontantRemise { get; set; }

    public decimal MontantFodec { get; set; }

    public decimal NetHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public string Observation { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public string CodeArticleFournisseur { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public int Nbvalise { get; set; }

    public int Nbimpression { get; set; }

    public decimal Qtimprimer { get; set; }
}
