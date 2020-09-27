using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JewelleryMine.Model;
using JewelleryMine.Model.Entities;

namespace JewelleryMine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelsController : ControllerBase
    {
        private readonly JewelContext _context;

        public JewelsController(JewelContext context)
        {
            _context = context;
        }

        // GET: api/Jewels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jewel>>> GetJewels()
        {
            return await _context.Jewels.ToListAsync();
        }

        // GET: api/Jewels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jewel>> GetJewel(Guid id)
        {
            var jewel = await _context.Jewels.FindAsync(id);

            if (jewel == null)
            {
                return NotFound();
            }

            return jewel;
        }

        // PUT: api/Jewels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJewel(Guid id, Jewel jewel)
        {
            if (id != jewel.Id)
            {
                return BadRequest();
            }

            _context.Entry(jewel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JewelExists(id))
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

        // POST: api/Jewels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Jewel>> PostJewel(Jewel jewel)
        {
            _context.Jewels.Add(jewel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJewel", new { id = jewel.Id }, jewel);
        }

        // DELETE: api/Jewels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Jewel>> DeleteJewel(Guid id)
        {
            var jewel = await _context.Jewels.FindAsync(id);
            if (jewel == null)
            {
                return NotFound();
            }

            _context.Jewels.Remove(jewel);
            await _context.SaveChangesAsync();

            return jewel;
        }

        private bool JewelExists(Guid id)
        {
            return _context.Jewels.Any(e => e.Id == id);
        }
    }
}
