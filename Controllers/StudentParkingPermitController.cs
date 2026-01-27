using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingPermitService.Data;
using ParkingPermitService.Models;

namespace ParkingPermitService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentParkingPermitsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentParkingPermitsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentParkingPermits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentParkingPermit>>> GetAll()
        {
            return await _context.StudentParkingPermits.ToListAsync();
        }

        // GET: api/StudentParkingPermits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentParkingPermit>> GetById(int id)
        {
            var permit = await _context.StudentParkingPermits.FindAsync(id);

            if (permit == null)
                return NotFound();

            return permit;
        }

        // POST: api/StudentParkingPermits
        [HttpPost]
        public async Task<ActionResult<StudentParkingPermit>> Create(StudentParkingPermit permit)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.StudentParkingPermits.Add(permit);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = permit.Id }, permit);
        }

        // PUT: api/StudentParkingPermits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StudentParkingPermit permit)
        {
            if (id != permit.Id)
                return BadRequest("Route id and body id must match.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var exists = await _context.StudentParkingPermits.AnyAsync(p => p.Id == id);
            if (!exists)
                return NotFound();

            _context.Entry(permit).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // 204
        }

        // DELETE: api/StudentParkingPermits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var permit = await _context.StudentParkingPermits.FindAsync(id);
            if (permit == null)
                return NotFound();

            _context.StudentParkingPermits.Remove(permit);
            await _context.SaveChangesAsync();

            return NoContent(); // 204
        }
    }
}
