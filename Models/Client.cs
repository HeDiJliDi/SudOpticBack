using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Client
{
    public string CodeClient { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string CodeForme { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string Responsable { get; set; } = null!;

    public string MatriculeFiscale { get; set; } = null!;

    public string RegistreCommerce { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string RibBanquaire { get; set; } = null!;

    public string Adresse1 { get; set; } = null!;

    public string CodePostal1 { get; set; } = null!;

    public string Ville1 { get; set; } = null!;

    public string Pays1 { get; set; } = null!;

    public string Tel1 { get; set; } = null!;

    public string Fax1 { get; set; } = null!;

    public string Adresse2 { get; set; } = null!;

    public string CodePostal2 { get; set; } = null!;

    public string Ville2 { get; set; } = null!;

    public string Pays2 { get; set; } = null!;

    public string Tel2 { get; set; } = null!;

    public string Fax2 { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;

    public bool Exoneration { get; set; }

    public string NumeroExoneration { get; set; } = null!;

    public DateTime? DateDebutExoneration { get; set; }

    public DateTime? DateFinExoneration { get; set; }

    public bool? PayerTva { get; set; }

    public bool? Assujetti { get; set; }

    public bool Fodec { get; set; }

    public bool Export { get; set; }

    public bool? TimbreFiscal { get; set; }

    public string Observation { get; set; } = null!;

    public bool? SolderFiche { get; set; }

    public decimal SeuilCredit { get; set; }

    public bool Gros { get; set; }

    public bool? RegimeReel { get; set; }

    public bool Ambilant { get; set; }

    public decimal SeuilMaximum { get; set; }

    public decimal SeuilMinimum { get; set; }

    public string CompteComptable { get; set; } = null!;

    public bool Bloquer { get; set; }

    public string Activite { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string CodeZoneClient { get; set; } = null!;

    public string CodeClientParent { get; set; } = null!;

    public bool? Autorise { get; set; }

    public string DateDernierBl { get; set; } = null!;

    public int NbreJourEngagementPaiement { get; set; }

    public int NbreJourAutorisationAlaVente { get; set; }

    public string DateDebutAutorisation { get; set; } = null!;

    public string CodeRaisonBlocageClient { get; set; } = null!;

    public DateTime DateCreation { get; set; }
    public decimal GetMaxCodeClient()
    {
        decimal maxCodeClient = 0;
        string connectionString = "server=192.168.1.200,1433;database=GrosOptiqueStandard;User ID=sa;Password=ideal2s;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sqlQuery = "SELECT MAX(CONVERT(Decimal, CodeClient)) AS CodeClient FROM [dbo].[Client]";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    maxCodeClient = Convert.ToDecimal(result);
                }
            }
        }

        return maxCodeClient;
    }
}

