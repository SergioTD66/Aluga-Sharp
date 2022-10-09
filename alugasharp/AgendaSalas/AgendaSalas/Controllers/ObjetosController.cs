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
    public class ObjetosController : ControllerBase
    {
        private readonly APIDbContext _context;

        public ObjetosController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Objetos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objetos>>> GetObjetos()
        {
            return await _context.Objetos.ToListAsync();
        }

        // GET: api/Objetos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Objetos>> GetObjetos(int id)
        {
            var objetos = await _context.Objetos.FindAsync(id);

            if (objetos == null)
            {
                return NotFound();
            }

            return objetos;
        }

        // PUT: api/Objetos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjetos(int id, Objetos objetos)
        {
            if (id != objetos.ObjetosId)
            {
                return BadRequest();
            }

            _context.Entry(objetos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjetosExists(id))
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

        // POST: api/Objetos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Objetos>> PostObjetos(Objetos objetos)
        {
            _context.Objetos.Add(objetos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjetos", new { id = objetos.ObjetosId }, objetos);
        }

        // DELETE: api/Objetos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjetos(int id)
        {
            var objetos = await _context.Objetos.FindAsync(id);
            if (objetos == null)
            {
                return NotFound();
            }

            _context.Objetos.Remove(objetos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObjetosExists(int id)
        {
            return _context.Objetos.Any(e => e.ObjetosId == id);
        }
    }
}
