using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHerosController : ControllerBase
    {
        private readonly SuperHeroContext _context;

        public SuperHerosController(SuperHeroContext context)
        {
            _context = context;
        }

        // GET: api/SuperHeroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuperHero.Models.SuperHero>>> GetSuperHeros()
        {
            return await _context.SuperHeros.ToListAsync();
        }

        // GET: api/SuperHeroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero.Models.SuperHero>> GetSuperHero(long id)
        {
            var superHero = await _context.SuperHeros.FindAsync(id);

            if (superHero == null)
            {
                return NotFound();
            }

            return superHero;
        }

        // PUT: api/SuperHeroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuperHero(long id, SuperHero.Models.SuperHero superHero)
        {
            if (id != superHero.Id)
            {
                return BadRequest();
            }

            _context.Entry(superHero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuperHeroExists(id))
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

        // POST: api/SuperHeroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuperHero.Models.SuperHero>> PostSuperHero(SuperHero.Models.SuperHero superHero)
        {
            _context.SuperHeros.Add(superHero);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSuperHero), new { id = superHero.Id }, superHero);
        }

        // DELETE: api/SuperHeroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuperHero(long id)
        {
            var superHero = await _context.SuperHeros.FindAsync(id);
            if (superHero == null)
            {
                return NotFound();
            }

            _context.SuperHeros.Remove(superHero);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuperHeroExists(long id)
        {
            return _context.SuperHeros.Any(e => e.Id == id);
        }
    }
}
