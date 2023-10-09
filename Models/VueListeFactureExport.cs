﻿using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeFactureExport
{
    public string RaisonSociale { get; set; } = null!;

    public string Etat { get; set; } = null!;

    public string NumeroFactureExport { get; set; } = null!;

    public DateTime DateFactureExport { get; set; }

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TimbreFiscal { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroFactureVente { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string? NumeroPrefacture { get; set; }
}