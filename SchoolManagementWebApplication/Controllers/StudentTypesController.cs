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
    public class StudentTypesController : ControllerBase
    {
        private readonly StudentDeatilContext _context;

        public StudentTypesController(StudentDeatilContext context)
        {
            _context = context;
        }

        // GET: api/StudentTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentType>>> GetStudentType()
        {
            return await _context.StudentType.ToListAsync();
        }

        // GET: api/StudentTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentType>> GetStudentType(int id)
        {
            var studentType = await _context.StudentType.FindAsync(id);

            if (studentType == null)
            {
                return NotFound();
            }

            return studentType;
        }

        // PUT: api/StudentTypes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentType(int id, StudentType studentType)
        {
            if (id != studentType.StudentTypeId)
            {
                return BadRequest();
            }

            _context.Entry(studentType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentTypeExists(id))
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

        // POST: api/StudentTypes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<StudentType>> PostStudentType(StudentType studentType)
        {
            _context.StudentType.Add(studentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentType", new { id = studentType.StudentTypeId }, studentType);
        }

        // DELETE: api/StudentTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentType>> DeleteStudentType(int id)
        {
            var studentType = await _context.StudentType.FindAsync(id);
            if (studentType == null)
            {
                return NotFound();
            }

            _context.StudentType.Remove(studentType);
            await _context.SaveChangesAsync();

            return studentType;
        }

        private bool StudentTypeExists(int id)
        {
            return _context.StudentType.Any(e => e.StudentTypeId == id);
        }
    }
}
