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
    public class ArticlesController : ControllerBase
    {
        private readonly I2S_SudOpticContext _context;

        public ArticlesController(I2S_SudOpticContext context)
        {
            _context = context;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetArticles()
        {
          if (_context.Articles == null)
          {
              return NotFound();
          }
            return  _context.Articles.Select(ar => new {
                codeArticle=ar.CodeArticle,
                reference=ar.Reference,
                couleur =  ar.CodeCouleur ,
                famille =   ar.CodeFamille,
                designation = ar.Designation,
                quantite = 10,
                prixVenteTTC=ar.PrixVenteTtc
            }).ToList();
        }
        [HttpGet("listArticleCommander/{codeLivreur}")]
        public async Task<ActionResult<IEnumerable<object>>> GetArticlesCommande(string codeLivreur)
        {
           
            var codeDepot=_context.Livreurs.Where(c=>c.CodeLivreur==codeLivreur).FirstOrDefault().CodeDepot;
            return _context.VueListeArticleAngulars
            .Select(article => new
            {
                article,
                Quantite = article.Qtmagsin - article.Qtreserver +
                           (_context.Stocks
                               .Where(stock => stock.CodeDepot == codeDepot && stock.CodeArticle == article.CodeArticle)
                               .Select(stock => (int?)stock.Quantite)
                               .FirstOrDefault() ?? 0),
                PrixVenteTTC =  _context.Articles.Where(e => e.CodeArticle == article.CodeArticle).FirstOrDefault().PrixVenteTtc,
                PrixHt = _context.Articles.Where(e => e.CodeArticle == article.CodeArticle).FirstOrDefault().PrixVenteHt,
                TauxTva = _context.Tvas.Where(e=>e.CodeTva== _context.Articles.Where(e => e.CodeArticle == article.CodeArticle).FirstOrDefault().CodeTva).FirstOrDefault().TauxTva,
                Fodec = _context.Articles.Where(e => e.CodeArticle == article.CodeArticle).FirstOrDefault().Fodec,
 

            })
            .Where(item => item.Quantite > 0)
            .ToList();

        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(string id)
        {
          if (_context.Articles == null)
          {
              return NotFound();
          }
            var article = await _context.Articles.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(string id, Article article)
        {
            if (id != article.CodeArticle)
            {
                return BadRequest();
            }

            _context.Entry(article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
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

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Article>> PostArticle(Article article)
        {
          if (_context.Articles == null)
          {
              return Problem("Entity set 'I2S_SudOpticContext.Articles'  is null.");
          }
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticle", new { id = article.CodeArticle }, article);
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(string id)
        {
            if (_context.Articles == null)
            {
                return NotFound();
            }
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleExists(string id)
        {
            return (_context.Articles?.Any(e => e.CodeArticle == id)).GetValueOrDefault();
        }
    }
}
