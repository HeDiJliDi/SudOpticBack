using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BanqueSociete
{
    public string CodeBanque { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public string RibBancaire { get; set; } = null!;

    public decimal MontantCommisionChéque { get; set; }

    public decimal MontantCommisionTraiteDecaissement { get; set; }

    public decimal MontantCommisionVirement { get; set; }

    public decimal MontantCommisionVirementDecaissement { get; set; }

    public decimal MontantCommisionTraitePret { get; set; }
}
