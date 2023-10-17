using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sud_Optic_Api.Context;
using Sud_Optic_Api.Models;

namespace Sud_Optic_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LigneBonCommandeVentesController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public LigneBonCommandeVentesController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/LigneBonCommandeVentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LigneBonCommandeVente>>> GetLigneBonCommandeVentes()
        {
          if (_context.LigneBonCommandeVentes == null)
          {
              return NotFound();
          }
            return await _context.LigneBonCommandeVentes.ToListAsync();
        }

        // GET: api/LigneBonCommandeVentes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetLigneBonCommandeVente(string id)
        {
            if (_context.LigneBonCommandeVentes == null)
            {
                return NotFound();
            }

            string decodedId = id.Replace('-', '/');

            var ligneBonCommandeVente = await _context.LigneBonCommandeVentes
                .Where(c => c.NumeroBonCommandeVente == decodedId)
                .Select(aa => new
                {
                    codeArticle = aa.CodeArticle,
                    quantite = aa.Quantite,
                    montantTTc = aa.MontantTtc
                })
                .ToListAsync();

            // Formater la date à l'extérieur de la requête
            var formattedLigneBonCommandeVente = ligneBonCommandeVente.Select(item => new
            {
                item.codeArticle,
                item.quantite,
                item.montantTTc
                // Ajoutez le formatage de date ici si nécessaire
            }).ToList();

            return formattedLigneBonCommandeVente;
        }


        // PUT: api/LigneBonCommandeVentes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLigneBonCommandeVente(string id, LigneBonCommandeVente ligneBonCommandeVente)
        {
            if (id != ligneBonCommandeVente.NumeroBonCommandeVente)
            {
                return BadRequest();
            }

            _context.Entry(ligneBonCommandeVente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LigneBonCommandeVenteExists(id))
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

        // POST: api/LigneBonCommandeVentes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LigneBonCommandeVente>> PostLigneBonCommandeVente(LigneBonCommandeVente ligneBonCommandeVente)
        {
          if (_context.LigneBonCommandeVentes == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.LigneBonCommandeVentes'  is null.");
          }
            _context.LigneBonCommandeVentes.Add(ligneBonCommandeVente);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LigneBonCommandeVenteExists(ligneBonCommandeVente.NumeroBonCommandeVente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLigneBonCommandeVente", new { id = ligneBonCommandeVente.NumeroBonCommandeVente }, ligneBonCommandeVente);
        }

        // DELETE: api/LigneBonCommandeVentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLigneBonCommandeVente(string id)
        {
            if (_context.LigneBonCommandeVentes == null)
            {
                return NotFound();
            }
            var ligneBonCommandeVente = await _context.LigneBonCommandeVentes.FindAsync(id);
            if (ligneBonCommandeVente == null)
            {
                return NotFound();
            }

            _context.LigneBonCommandeVentes.Remove(ligneBonCommandeVente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LigneBonCommandeVenteExists(string id)
        {
            return (_context.LigneBonCommandeVentes?.Any(e => e.NumeroBonCommandeVente == id)).GetValueOrDefault();
        }
    }
}
