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
    public class ParametreDiversController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public ParametreDiversController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/ParametreDivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParametreDiver>>> GetParametreDivers()
        {
          if (_context.ParametreDivers == null)
          {
              return NotFound();
          }
            return await _context.ParametreDivers.ToListAsync();
        }
        [HttpGet("Utilities")]
        public async Task<ActionResult<IEnumerable<object>>> GetParametreDiversUtilities()
        {
            if (_context.ParametreDivers == null)
            {
                return NotFound();
            }
            return await _context.ParametreDivers.Select(ff => new
            {
                TauxMajoration = ff.TauxMajoration,
                TauxFodec = ff.TauxFodec,
                TimbreFiscal = ff.TimbreFiscal

            }).ToListAsync();
        }

        // GET: api/ParametreDivers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParametreDiver>> GetParametreDiver(string id)
        {
          if (_context.ParametreDivers == null)
          {
              return NotFound();
          }
            var parametreDiver = await _context.ParametreDivers.FindAsync(id);

            if (parametreDiver == null)
            {
                return NotFound();
            }

            return parametreDiver;
        }

        // PUT: api/ParametreDivers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParametreDiver(string id, ParametreDiver parametreDiver)
        {
            if (id != parametreDiver.CodeSociete)
            {
                return BadRequest();
            }

            _context.Entry(parametreDiver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParametreDiverExists(id))
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

        // POST: api/ParametreDivers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ParametreDiver>> PostParametreDiver(ParametreDiver parametreDiver)
        {
          if (_context.ParametreDivers == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.ParametreDivers'  is null.");
          }
            _context.ParametreDivers.Add(parametreDiver);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ParametreDiverExists(parametreDiver.CodeSociete))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetParametreDiver", new { id = parametreDiver.CodeSociete }, parametreDiver);
        }

        // DELETE: api/ParametreDivers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParametreDiver(string id)
        {
            if (_context.ParametreDivers == null)
            {
                return NotFound();
            }
            var parametreDiver = await _context.ParametreDivers.FindAsync(id);
            if (parametreDiver == null)
            {
                return NotFound();
            }

            _context.ParametreDivers.Remove(parametreDiver);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParametreDiverExists(string id)
        {
            return (_context.ParametreDivers?.Any(e => e.CodeSociete == id)).GetValueOrDefault();
        }
    }
}
