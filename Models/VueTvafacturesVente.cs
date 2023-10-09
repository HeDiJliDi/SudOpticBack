using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueTvafacturesVente
{
    public string NumeroFactureVente { get; set; } = null!;

    public DateTime DateFactureVente { get; set; }

    public string CodeClient { get; set; } = null!;

    public decimal Base0 { get; set; }

    public decimal Base6 { get; set; }

    public decimal Tva6 { get; set; }

    public decimal Base12 { get; set; }

    public decimal Tva12 { get; set; }

    public decimal Base18 { get; set; }

    public decimal Tva18 { get; set; }

    public decimal TimbreFiscal { get; set; }

    public decimal TotalTtc { get; set; }
}
