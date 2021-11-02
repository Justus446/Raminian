using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaminianAPI;
using RaminianAPI.Models;

namespace RaminianAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
        private readonly ApiDBContext _context;

        public WarehousesController(ApiDBContext context)
        {
            _context = context;
        }

        // GET: api/Warehouses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Warehouses>>> GetWarehouses()
        {
            return await _context.Warehouses.ToListAsync();
        }

        // GET: api/Warehouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Warehouses>> GetWarehouses(int id)
        {
            var warehouses = await _context.Warehouses.FindAsync(id);

            if (warehouses == null)
            {
                return NotFound();
            }

            return warehouses;
        }

        // PUT: api/Warehouses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarehouses(int id, Warehouses warehouses)
        {
            if (id != warehouses.WareId)
            {
                return BadRequest();
            }

            _context.Entry(warehouses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WarehousesExists(id))
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

        // POST: api/Warehouses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Warehouses>> PostWarehouses(Warehouses warehouses)
        {
            _context.Warehouses.Add(warehouses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWarehouses", new { id = warehouses.WareId }, warehouses);
        }

        // DELETE: api/Warehouses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWarehouses(int id)
        {
            var warehouses = await _context.Warehouses.FindAsync(id);
            if (warehouses == null)
            {
                return NotFound();
            }

            _context.Warehouses.Remove(warehouses);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WarehousesExists(int id)
        {
            return _context.Warehouses.Any(e => e.WareId == id);
        }
    }
}
