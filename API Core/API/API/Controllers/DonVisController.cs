using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonVisController : ControllerBase
    {
        private readonly TestDatabaseContext _context;

        public DonVisController(TestDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/DonVis
        [HttpGet]
        public IEnumerable<DonVi> GetDonVi()
        {
            return _context.DonVi;
        }

        // GET: api/DonVis/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDonVi([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donVi = await _context.DonVi.FindAsync(id);

            if (donVi == null)
            {
                return NotFound();
            }

            return Ok(donVi);
        }

        // PUT: api/DonVis/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonVi([FromRoute] string id, [FromBody] DonVi donVi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donVi.Madonvi)
            {
                return BadRequest();
            }

            _context.Entry(donVi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonViExists(id))
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

        // POST: api/DonVis
        [HttpPost]
        public async Task<IActionResult> PostDonVi([FromBody] DonVi donVi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DonVi.Add(donVi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DonViExists(donVi.Madonvi))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDonVi", new { id = donVi.Madonvi }, donVi);
        }

        // DELETE: api/DonVis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonVi([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donVi = await _context.DonVi.FindAsync(id);
            if (donVi == null)
            {
                return NotFound();
            }

            _context.DonVi.Remove(donVi);
            await _context.SaveChangesAsync();

            return Ok(donVi);
        }

        private bool DonViExists(string id)
        {
            return _context.DonVi.Any(e => e.Madonvi == id);
        }
    }
}