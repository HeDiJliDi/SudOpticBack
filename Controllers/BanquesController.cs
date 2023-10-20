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
    public class BanquesController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public BanquesController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/Banques
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Banque>>> GetBanques()
        {
          if (_context.Banques == null)
          {
              return NotFound();
          }
            return await _context.Banques.ToListAsync();
        }

        // GET: api/Banques/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Banque>> GetBanque(string id)
        {
          if (_context.Banques == null)
          {
              return NotFound();
          }
            var banque = await _context.Banques.FindAsync(id);

            if (banque == null)
            {
                return NotFound();
            }

            return banque;
        }

        // PUT: api/Banques/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBanque(string id, Banque banque)
        {
            if (id != banque.CodeBanque)
            {
                return BadRequest();
            }

            _context.Entry(banque).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BanqueExists(id))
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

        // POST: api/Banques
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Banque>> PostBanque(Banque banque)
        {
          if (_context.Banques == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.Banques'  is null.");
          }
            _context.Banques.Add(banque);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BanqueExists(banque.CodeBanque))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBanque", new { id = banque.CodeBanque }, banque);
        }

        // DELETE: api/Banques/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBanque(string id)
        {
            if (_context.Banques == null)
            {
                return NotFound();
            }
            var banque = await _context.Banques.FindAsync(id);
            if (banque == null)
            {
                return NotFound();
            }

            _context.Banques.Remove(banque);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BanqueExists(string id)
        {
            return (_context.Banques?.Any(e => e.CodeBanque == id)).GetValueOrDefault();
        }
    }
}
