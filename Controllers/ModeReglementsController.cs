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
    public class ModeReglementsController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public ModeReglementsController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/ModeReglements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModeReglement>>> GetModeReglements()
        {
          if (_context.ModeReglements == null)
          {
              return NotFound();
          }
            return await _context.ModeReglements.ToListAsync();
        }

        // GET: api/ModeReglements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModeReglement>> GetModeReglement(string id)
        {
          if (_context.ModeReglements == null)
          {
              return NotFound();
          }
            var modeReglement = await _context.ModeReglements.FindAsync(id);

            if (modeReglement == null)
            {
                return NotFound();
            }

            return modeReglement;
        }

        // PUT: api/ModeReglements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModeReglement(string id, ModeReglement modeReglement)
        {
            if (id != modeReglement.CodeModeReglement)
            {
                return BadRequest();
            }

            _context.Entry(modeReglement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeReglementExists(id))
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

        // POST: api/ModeReglements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ModeReglement>> PostModeReglement(ModeReglement modeReglement)
        {
          if (_context.ModeReglements == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.ModeReglements'  is null.");
          }
            _context.ModeReglements.Add(modeReglement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ModeReglementExists(modeReglement.CodeModeReglement))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetModeReglement", new { id = modeReglement.CodeModeReglement }, modeReglement);
        }

        // DELETE: api/ModeReglements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModeReglement(string id)
        {
            if (_context.ModeReglements == null)
            {
                return NotFound();
            }
            var modeReglement = await _context.ModeReglements.FindAsync(id);
            if (modeReglement == null)
            {
                return NotFound();
            }

            _context.ModeReglements.Remove(modeReglement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModeReglementExists(string id)
        {
            return (_context.ModeReglements?.Any(e => e.CodeModeReglement == id)).GetValueOrDefault();
        }
    }
}
