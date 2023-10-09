using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ObjectifRepresentantParQuantite
{
    public int NumeroObjectif { get; set; }

    public string PeriodeDu { get; set; } = null!;

    public string PeriodeAu { get; set; } = null!;

    public int NbreMoisPrecedent { get; set; }

    public string CodeMarque { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string HeureCreation { get; set; } = null!;

    public string NonUtilisateur { get; set; } = null!;

    public bool ForcageAcheivement { get; set; }

    public string AcheverPar { get; set; } = null!;

    public string AcheverLe { get; set; } = null!;

    public string NoteSurObjectif { get; set; } = null!;

    public int TotalQuantite { get; set; }

    public int TotalQuantiteFaitAvantPeriode { get; set; }
}
