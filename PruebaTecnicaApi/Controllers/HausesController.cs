using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnicaApi;
using PruebaTecnicaApi.Data;

namespace PruebaTecnicaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HausesController : ControllerBase
    {
        private readonly DataContext _context;

        public HausesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Hauses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hause>>> GetHause()
        {
            return await _context.Hause.ToListAsync();
        }

        // GET: api/Hauses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hause>> GetHause(int id)
        {
            var hause = await _context.Hause.FindAsync(id);

            if (hause == null)
            {
                return NotFound();
            }

            return hause;
        }

        // PUT: api/Hauses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHause(int id, Hause hause)
        {
            if (id != hause.Id)
            {
                return BadRequest();
            }

            _context.Entry(hause).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HauseExists(id))
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

        // POST: api/Hauses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hause>> PostHause(Hause hause)
        {
            _context.Hause.Add(hause);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHause", new { id = hause.Id }, hause);
        }

        // DELETE: api/Hauses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHause(int id)
        {
            var hause = await _context.Hause.FindAsync(id);
            if (hause == null)
            {
                return NotFound();
            }

            _context.Hause.Remove(hause);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HauseExists(int id)
        {
            return _context.Hause.Any(e => e.Id == id);
        }
    }
}
