using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class FicheIntervention
{
    public string NumeroFicheIntervention { get; set; } = null!;

    public DateTime DateFicheIntervention { get; set; }

    public decimal Duree { get; set; }

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

    public string CodeNatureIntervention { get; set; } = null!;

    public string? CodeDepot { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NumeroReception { get; set; } = null!;

    public string ComposantUtiliser { get; set; } = null!;

    public bool SurSite { get; set; }

    public string Reclamation { get; set; } = null!;

    public bool? Afacturer { get; set; }

    public bool Gratuit { get; set; }

    public decimal MontantHt { get; set; }

    public bool Contrat { get; set; }
}
