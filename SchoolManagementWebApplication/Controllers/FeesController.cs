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
    public class FeesController : ControllerBase
    {
        private readonly StudentDeatilContext _context;

        public FeesController(StudentDeatilContext context)
        {
            _context = context;
        }

        // GET: api/Fees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fees>>> GetFees()
        {
            return await _context.Fees.ToListAsync();
        }

        // GET: api/Fees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fees>> GetFees(int id)
        {
            var fees = await _context.Fees.FindAsync(id);

            if (fees == null)
            {
                return NotFound();
            }

            return fees;
        }

        // PUT: api/Fees/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFees(int id, Fees fees)
        {
            if (id != fees.FeesId)
            {
                return BadRequest();
            }

            _context.Entry(fees).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeesExists(id))
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

        // POST: api/Fees
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Fees>> PostFees(Fees fees)
        {
            _context.Fees.Add(fees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFees", new { id = fees.FeesId }, fees);
        }

        // DELETE: api/Fees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fees>> DeleteFees(int id)
        {
            var fees = await _context.Fees.FindAsync(id);
            if (fees == null)
            {
                return NotFound();
            }

            _context.Fees.Remove(fees);
            await _context.SaveChangesAsync();

            return fees;
        }

        private bool FeesExists(int id)
        {
            return _context.Fees.Any(e => e.FeesId == id);
        }
    }
}
