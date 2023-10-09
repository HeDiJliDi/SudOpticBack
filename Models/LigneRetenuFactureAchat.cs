using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneRetenuFactureAchat
{
    public string NumeroRetenu { get; set; } = null!;

    public string NumeroFactureAchat { get; set; } = null!;

    public string CodeRetenu { get; set; } = null!;

    public decimal TauxRetenu { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public decimal MontantRetenu { get; set; }
}
