using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgendaSalas.Context;
using AgendaSalas.Models;

namespace AgendaSalas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodoesController : ControllerBase
    {
        private readonly APIDbContext _context;

        public PeriodoesController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Periodoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Periodo>>> GetPeriodo()
        {
            return await _context.Periodo.ToListAsync();
        }

        // GET: api/Periodoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Periodo>> GetPeriodo(int id)
        {
            var periodo = await _context.Periodo.FindAsync(id);

            if (periodo == null)
            {
                return NotFound();
            }

            return periodo;
        }

        // PUT: api/Periodoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodo(int id, Periodo periodo)
        {
            if (id != periodo.PeriodoId)
            {
                return BadRequest();
            }

            _context.Entry(periodo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodoExists(id))
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

        // POST: api/Periodoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Periodo>> PostPeriodo(Periodo periodo)
        {
            _context.Periodo.Add(periodo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeriodo", new { id = periodo.PeriodoId }, periodo);
        }

        // DELETE: api/Periodoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeriodo(int id)
        {
            var periodo = await _context.Periodo.FindAsync(id);
            if (periodo == null)
            {
                return NotFound();
            }

            _context.Periodo.Remove(periodo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PeriodoExists(int id)
        {
            return _context.Periodo.Any(e => e.PeriodoId == id);
        }
    }
}
