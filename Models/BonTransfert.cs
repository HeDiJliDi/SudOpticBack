using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonTransfert
{
    public string NumeroBonTransfert { get; set; } = null!;

    public DateTime DateBonTransfert { get; set; }

    public string CodeDepotSource { get; set; } = null!;

    public string CodeDepotDestination { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeCamion { get; set; } = null!;

    public DateTime DateRetour { get; set; }

    public bool Valider { get; set; }

    public string NomConfirmation { get; set; } = null!;

    public DateTime DateConfirmation { get; set; }

    public string NomAnnulationConfirmation { get; set; } = null!;

    public DateTime DateAnnulationConfirmation { get; set; }

    public string NumeroBonCommandeVente { get; set; } = null!;
}
