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
    public class AdmissionFormsController : ControllerBase
    {
        private readonly StudentDeatilContext _context;

        public AdmissionFormsController(StudentDeatilContext context)
        {
            _context = context;
        }

        // GET: api/AdmissionForms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdmissionForm>>> GetAdmissionForm()
        {
            return await _context.AdmissionForm.ToListAsync();
        }

        // GET: api/AdmissionForms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdmissionForm>> GetAdmissionForm(int id)
        {
            var admissionForm = await _context.AdmissionForm.FindAsync(id);

            if (admissionForm == null)
            {
                return NotFound();
            }

            return admissionForm;
        }

        // PUT: api/AdmissionForms/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmissionForm(int id, AdmissionForm admissionForm)
        {
            if (id != admissionForm.AdmissionId)
            {
                return BadRequest();
            }

            _context.Entry(admissionForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdmissionFormExists(id))
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

        // POST: api/AdmissionForms
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AdmissionForm>> PostAdmissionForm(AdmissionForm admissionForm)
        {
            _context.AdmissionForm.Add(admissionForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdmissionForm", new { id = admissionForm.AdmissionId }, admissionForm);
        }

        // DELETE: api/AdmissionForms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AdmissionForm>> DeleteAdmissionForm(int id)
        {
            var admissionForm = await _context.AdmissionForm.FindAsync(id);
            if (admissionForm == null)
            {
                return NotFound();
            }

            _context.AdmissionForm.Remove(admissionForm);
            await _context.SaveChangesAsync();

            return admissionForm;
        }

        private bool AdmissionFormExists(int id)
        {
            return _context.AdmissionForm.Any(e => e.AdmissionId == id);
        }
    }
}
