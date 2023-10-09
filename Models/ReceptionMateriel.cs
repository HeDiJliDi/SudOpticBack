using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ReceptionMateriel
{
    public string NumeroReception { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public DateTime DateReception { get; set; }

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string LibellePanne { get; set; } = null!;

    public string NumeroEtat { get; set; } = null!;

    public string Piece { get; set; } = null!;

    public bool Garentie { get; set; }

    public bool Contrat { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string DateEnvoie { get; set; } = null!;

    public string DateRetour { get; set; } = null!;
}
