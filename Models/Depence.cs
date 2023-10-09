﻿using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Depence
{
    public string NumeroDepence { get; set; } = null!;

    public DateTime DateDepence { get; set; }

    public string Libelle { get; set; } = null!;

    public decimal Montant { get; set; }

    public string Observation { get; set; } = null!;

    public string? NomUtilisateur { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string? NumeroEtat { get; set; }

    public string NumeroBonCommandeAchat { get; set; } = null!;
}
