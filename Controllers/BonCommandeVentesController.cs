using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sud_Optic_Api.Context;
using Sud_Optic_Api.Models;
using Sud_Optic_Api.ModelsDto1;

namespace Sud_Optic_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonCommandeVentesController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public BonCommandeVentesController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/BonCommandeVentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BonCommandeVente>>> GetBonCommandeVentes()
        {
          if (_context.BonCommandeVentes == null)
          {
              return NotFound();
          }
            return await _context.BonCommandeVentes.ToListAsync();
        }

        // GET: api/BonCommandeVentes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BonCommandeVente>> GetBonCommandeVente(string id)
        {
          if (_context.BonCommandeVentes == null)
          {
              return NotFound();
          }
            var bonCommandeVente = await _context.BonCommandeVentes.FindAsync(id);

            if (bonCommandeVente == null)
            {
                return NotFound();
            }

            return bonCommandeVente;
        }

        // PUT: api/BonCommandeVentes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBonCommandeVente(string id, BonCommandeVente bonCommandeVente)
        {
            if (id != bonCommandeVente.NumeroBonCommandeVente)
            {
                return BadRequest();
            }

            _context.Entry(bonCommandeVente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BonCommandeVenteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        //[HttpPost("list")]
        //public async Task<ActionResult<object>> GetListBonCommandeVente([FromBody] DateBonCommande B_Commande )

        //{
        //    var bnCmd= _context.BonCommandeVentes.Where(e => e.DateCreation < B_Commande.dateFin && e.DateCreation > B_Commande.dateDebut && e.CodeLivreur == B_Commande.codeLivreur).Select(aa => new {

        //        numeroBonCommande = aa.NumeroBonCommandeVente,
        //        nomClient = _context.Clients.Where(c => c.CodeClient == aa.CodeClient).FirstOrDefault().RaisonSociale,
        //        totalTTc = aa.TotalTtc,
        //        date = aa.DateCreation,


        //    }).ToListAsync();
        //    return bnCmd;


        //}
        [HttpPost("list")]
        public async Task<ActionResult<object>> GetListBonCommandeVente([FromBody] DateBonCommande B_Commande)
        {
            var bnCmd = await _context.BonCommandeVentes
                .Where(e => e.DateCreation < B_Commande.dateFin && e.DateCreation > B_Commande.dateDebut && e.CodeLivreur == B_Commande.codeLivreur)
                .Select(aa => new
                {
                    numeroBonCommande = aa.NumeroBonCommandeVente,
                    nomClient = _context.Clients.Where(c => c.CodeClient == aa.CodeClient).FirstOrDefault().RaisonSociale,
                    totalTTc = aa.TotalTtc,
                    date = aa.DateCreation // Ne pas formater ici
                }).OrderByDescending(item => item.date)
                .ToListAsync();

            // Formater la date à l'extérieur de la requête
            var formattedBnCmd = bnCmd.Select(item => new
            {
                item.numeroBonCommande,
                item.nomClient,
                item.totalTTc,
                date = item.date.ToString("dd/MM/yyyy")
            }).ToList();

            return formattedBnCmd;
        }

        // POST: api/BonCommandeVentes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<object>> PostBonCommandeVente([FromBody] BonCommandeDTo B_Commande_Vente )

        {
            BonCommandeVente bonCommandeVente=new BonCommandeVente();
            bonCommandeVente = B_Commande_Vente.bonCommande;
            List<LigneBonCommandeVente> ligneBonCommande=new List<LigneBonCommandeVente>();
            ligneBonCommande = B_Commande_Vente.ligneCommande;
            CompteurPiece cp = new CompteurPiece();
            cp = _context.CompteurPieces.Where(e => e.CodeSociete == "SOC001" && e.NomPiecer == "BonCommandeVente").FirstOrDefault();
            var strategy = _context.Database.CreateExecutionStrategy();
            strategy.Execute(() =>
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    { _context.BonCommandeVentes.Add(bonCommandeVente);
                        foreach(LigneBonCommandeVente ligne in ligneBonCommande)
                        {
                            _context.LigneBonCommandeVentes.Add(ligne);
                        }
                        cp.Compteur = (Convert.ToInt32(cp.Compteur) + 1).ToString("#00000");
                        _context.Entry(cp).State = EntityState.Modified;
                        _context.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();


                    }
                }
            });

            return NoContent();
        }

        // DELETE: api/BonCommandeVentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBonCommandeVente(string id)
        {
            if (_context.BonCommandeVentes == null)
            {
                return NotFound();
            }
            var bonCommandeVente = await _context.BonCommandeVentes.FindAsync(id);
            if (bonCommandeVente == null)
            {
                return NotFound();
            }

            _context.BonCommandeVentes.Remove(bonCommandeVente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BonCommandeVenteExists(string id)
        {
            return (_context.BonCommandeVentes?.Any(e => e.NumeroBonCommandeVente == id)).GetValueOrDefault();
        }
        public string GetIdByCompteur(string NomPiecier)
        {
            var model = from r in _context.CompteurPieces
                        where r.NomPiecer == NomPiecier
                        select (r.PrefixPiece + r.Annee + r.Compteur);
            return model.FirstOrDefault() ?? string.Empty;

        }
    }
}
