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
    public class SuperPoderesController : ControllerBase
    {
        private readonly SuperPoderContext _context;

        public SuperPoderesController(SuperPoderContext context)
        {
            _context = context;
        }

        // GET: api/SuperPoderes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuperPoder>>> GetSuperPoderes()
        {
            return await _context.SuperPoderes.ToListAsync();
        }

        // GET: api/SuperPoderes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperPoder>> GetSuperPoder(long id)
        {
            var superPoder = await _context.SuperPoderes.FindAsync(id);

            if (superPoder == null)
            {
                return NotFound();
            }

            return superPoder;
        }

        // PUT: api/SuperPoderes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuperPoder(long id, SuperPoder superPoder)
        {
            if (id != superPoder.Id)
            {
                return BadRequest();
            }

            _context.Entry(superPoder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuperPoderExists(id))
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

        // POST: api/SuperPoderes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuperPoder>> PostSuperPoder(SuperPoder superPoder)
        {
            _context.SuperPoderes.Add(superPoder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSuperPoder), new { id = superPoder.Id }, superPoder);
        }

        // DELETE: api/SuperPoderes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuperPoder(long id)
        {
            var superPoder = await _context.SuperPoderes.FindAsync(id);
            if (superPoder == null)
            {
                return NotFound();
            }

            _context.SuperPoderes.Remove(superPoder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuperPoderExists(long id)
        {
            return _context.SuperPoderes.Any(e => e.Id == id);
        }
    }
}
