using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementWebApplication.Models;

namespace SchoolManagementWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardiansController : ControllerBase
    {
        private readonly StudentDeatilContext _context;

        public GuardiansController(StudentDeatilContext context)
        {
            _context = context;
        }

        // GET: api/Guardians
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guardians>>> GetGuardian()
        {
            return await _context.Guardian.ToListAsync();
        }

        // GET: api/Guardians/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guardians>> GetGuardians(int id)
        {
            var guardians = await _context.Guardian.FindAsync(id);

            if (guardians == null)
            {
                return NotFound();
            }

            return guardians;
        }

        // PUT: api/Guardians/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuardians(int id, Guardians guardians)
        {
            if (id != guardians.GuardianId)
            {
                return BadRequest();
            }

            _context.Entry(guardians).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuardiansExists(id))
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

        // POST: api/Guardians
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Guardians>> PostGuardians(Guardians guardians)
        {
            _context.Guardian.Add(guardians);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuardians", new { id = guardians.GuardianId }, guardians);
        }

        // DELETE: api/Guardians/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Guardians>> DeleteGuardians(int id)
        {
            var guardians = await _context.Guardian.FindAsync(id);
            if (guardians == null)
            {
                return NotFound();
            }

            _context.Guardian.Remove(guardians);
            await _context.SaveChangesAsync();

            return guardians;
        }

        private bool GuardiansExists(int id)
        {
            return _context.Guardian.Any(e => e.GuardianId == id);
        }
    }
}
