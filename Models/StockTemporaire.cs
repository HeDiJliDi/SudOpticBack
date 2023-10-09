﻿using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class StockTemporaire
{
    public string CodeArticle { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal PrixUnitaireAchat { get; set; }

    public decimal QuaniteMinimale { get; set; }

    public decimal QuantiteMaximale { get; set; }
}
