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
    public class TvasController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public TvasController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/Tvas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tva>>> GetTvas()
        {
          if (_context.Tvas == null)
          {
              return NotFound();
          }
            return await _context.Tvas.ToListAsync();
        }

        // GET: api/Tvas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tva>> GetTva(string id)
        {
          if (_context.Tvas == null)
          {
              return NotFound();
          }
            var tva = await _context.Tvas.FindAsync(id);

            if (tva == null)
            {
                return NotFound();
            }

            return tva;
        }

        // PUT: api/Tvas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTva(string id, Tva tva)
        {
            if (id != tva.CodeTva)
            {
                return BadRequest();
            }

            _context.Entry(tva).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvaExists(id))
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

        // POST: api/Tvas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tva>> PostTva(Tva tva)
        {
          if (_context.Tvas == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.Tvas'  is null.");
          }
            _context.Tvas.Add(tva);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvaExists(tva.CodeTva))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTva", new { id = tva.CodeTva }, tva);
        }

        // DELETE: api/Tvas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTva(string id)
        {
            if (_context.Tvas == null)
            {
                return NotFound();
            }
            var tva = await _context.Tvas.FindAsync(id);
            if (tva == null)
            {
                return NotFound();
            }

            _context.Tvas.Remove(tva);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TvaExists(string id)
        {
            return (_context.Tvas?.Any(e => e.CodeTva == id)).GetValueOrDefault();
        }
    }
}
