using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Semaine
{
    public int Annnee { get; set; }

    public int Mois { get; set; }

    public string CodeSemaine { get; set; } = null!;

    public DateTime DateDebutSemaine { get; set; }

    public DateTime DateFinSemaine { get; set; }
}
