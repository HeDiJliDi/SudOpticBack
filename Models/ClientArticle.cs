using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ClientArticle
{
    public string CodeArticle { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public decimal DernierPrixVente { get; set; }

    public decimal TauxRemise { get; set; }
}
