using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ContratClient
{
    public string NumeroContratClient { get; set; } = null!;

    public DateTime DateContratClient { get; set; }

    public string CodeClient { get; set; } = null!;

    public string CodeTypeContrat { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public bool Actif { get; set; }

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public int OccuranceFacturation { get; set; }

    public decimal MontantHt { get; set; }

    public DateTime DatePremiereFactration { get; set; }

    public bool SuiteContrat { get; set; }

    public decimal TauxRemise { get; set; }

    public string ModeFacturation { get; set; } = null!;

    public string Observation { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public DateTime DateFinProlongation { get; set; }
}
