using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeFicheIntervention
{
    public string NumeroFicheIntervention { get; set; } = null!;

    public DateTime DateFicheIntervention { get; set; }

    public string CodeClient { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeIntervenant { get; set; } = null!;

    public string NumeroPieceVente { get; set; } = null!;

    public string LibelleIntervantion { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public decimal Duree { get; set; }

    public string CodeNatureIntervention { get; set; } = null!;

    public string NumeroEtat { get; set; } = null!;

    public string NumeroReception { get; set; } = null!;

    public string Etat { get; set; } = null!;
}
