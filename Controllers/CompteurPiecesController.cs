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
    public class CompteurPiecesController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public CompteurPiecesController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/CompteurPieces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompteurPiece>>> GetCompteurPieces()
        {
          if (_context.CompteurPieces == null)
          {
              return NotFound();
          }
            return await _context.CompteurPieces.ToListAsync();
        }
        [HttpGet("GetCompteurPieceByNomPiecer")]
        public ActionResult<CompteurPiece> GetCompteurPiece()
        {
            var compteurPiece = _context.CompteurPieces.FirstOrDefault(c => c.NomPiecer == "BonCommandeVente");

            if (compteurPiece == null)
            {
                return NotFound(); // Renvoie une réponse 404 si aucune ligne n'est trouvée
            }

            return Ok(compteurPiece); // Renvoie la ligne de CompteurPiece si trouvée
        }
        // GET: api/CompteurPieces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompteurPiece>> GetCompteurPiece(string id)
        {
          if (_context.CompteurPieces == null)
          {
              return NotFound();
          }
            var compteurPiece = await _context.CompteurPieces.FindAsync(id);

            if (compteurPiece == null)
            {
                return NotFound();
            }

            return compteurPiece;
        }

        // PUT: api/CompteurPieces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompteurPiece(string id, CompteurPiece compteurPiece)
        {
            if (id != compteurPiece.CodeSociete)
            {
                return BadRequest();
            }

            _context.Entry(compteurPiece).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompteurPieceExists(id))
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

        // POST: api/CompteurPieces
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompteurPiece>> PostCompteurPiece(CompteurPiece compteurPiece)
        {
          if (_context.CompteurPieces == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.CompteurPieces'  is null.");
          }
            _context.CompteurPieces.Add(compteurPiece);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CompteurPieceExists(compteurPiece.CodeSociete))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCompteurPiece", new { id = compteurPiece.CodeSociete }, compteurPiece);
        }

        // DELETE: api/CompteurPieces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompteurPiece(string id)
        {
            if (_context.CompteurPieces == null)
            {
                return NotFound();
            }
            var compteurPiece = await _context.CompteurPieces.FindAsync(id);
            if (compteurPiece == null)
            {
                return NotFound();
            }

            _context.CompteurPieces.Remove(compteurPiece);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompteurPieceExists(string id)
        {
            return (_context.CompteurPieces?.Any(e => e.CodeSociete == id)).GetValueOrDefault();
        }
    }
}
