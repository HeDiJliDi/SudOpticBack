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
    public class FamilleArticlesController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public FamilleArticlesController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/FamilleArticles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FamilleArticle>>> GetFamilleArticles()
        {
          if (_context.FamilleArticles == null)
          {
              return NotFound();
          }
            return await _context.FamilleArticles.ToListAsync();
        }

        // GET: api/FamilleArticles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FamilleArticle>> GetFamilleArticle(string id)
        {
          if (_context.FamilleArticles == null)
          {
              return NotFound();
          }
            var familleArticle = await _context.FamilleArticles.FindAsync(id);

            if (familleArticle == null)
            {
                return NotFound();
            }

            return familleArticle;
        }

        // PUT: api/FamilleArticles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamilleArticle(string id, FamilleArticle familleArticle)
        {
            if (id != familleArticle.CodeFamille)
            {
                return BadRequest();
            }

            _context.Entry(familleArticle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamilleArticleExists(id))
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

        // POST: api/FamilleArticles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FamilleArticle>> PostFamilleArticle(FamilleArticle familleArticle)
        {
          if (_context.FamilleArticles == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.FamilleArticles'  is null.");
          }
            _context.FamilleArticles.Add(familleArticle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FamilleArticleExists(familleArticle.CodeFamille))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFamilleArticle", new { id = familleArticle.CodeFamille }, familleArticle);
        }

        // DELETE: api/FamilleArticles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFamilleArticle(string id)
        {
            if (_context.FamilleArticles == null)
            {
                return NotFound();
            }
            var familleArticle = await _context.FamilleArticles.FindAsync(id);
            if (familleArticle == null)
            {
                return NotFound();
            }

            _context.FamilleArticles.Remove(familleArticle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FamilleArticleExists(string id)
        {
            return (_context.FamilleArticles?.Any(e => e.CodeFamille == id)).GetValueOrDefault();
        }
    }
}
