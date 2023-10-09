using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneObjectifRepresentantParQuantite
{
    public int NumeroObjectif { get; set; }

    public int NumeroOrdre { get; set; }

    public int Quantite { get; set; }

    public bool AcheveReelement { get; set; }

    public int QuantiteAchevee { get; set; }
}
