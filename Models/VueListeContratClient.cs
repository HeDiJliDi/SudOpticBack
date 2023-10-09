using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeContratClient
{
    public string NumeroContratClient { get; set; } = null!;

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

    public string Observation { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string LibelleTypeContrat { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string ModeFacturation { get; set; } = null!;
}
