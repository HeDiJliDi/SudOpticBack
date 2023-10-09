using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ObjectifSemaine
{
    public string NumeroObjectifSemaine { get; set; } = null!;

    public DateTime DateSaisie { get; set; }

    public string CodeMoisAnnee { get; set; } = null!;

    public int NumeroSemaine { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int QuantiteObjectif { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;
}
