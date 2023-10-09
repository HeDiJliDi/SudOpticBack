using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Banque
{
    public string CodeBanque { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string Siege { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string CodePostal { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Pays { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;
}
