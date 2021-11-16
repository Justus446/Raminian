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
    public class eComm_non_eCommController : ControllerBase
    {
        private readonly ApiDBContext _context;

        public eComm_non_eCommController(ApiDBContext context)
        {
            _context = context;
        }

        // GET: api/eComm_non_eComm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<eComm_non_eComm>>> GetEcommerce()
        {
            //return await _context.Ecommerce.ToListAsync();
            var str = "SELECT sku, REPLACE(description,':','') AS [description], price FROM _eCommerce_Non_eComm WHERE WareID=1;";

            return await _context.Ecommerce.FromSqlRaw(str)
                .ToListAsync() ;
            
            
        }

        // GET: api/eComm_non_eComm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<eComm_non_eComm>> GeteComm_non_eComm(int id)
        {
            var eComm_non_eComm = await _context.Ecommerce.FindAsync(id);

            if (eComm_non_eComm == null)
            {
                return NotFound();
            }

            return eComm_non_eComm;
        }

        // PUT: api/eComm_non_eComm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PuteComm_non_eComm(int id, eComm_non_eComm eComm_non_eComm)
        {
            if (id != eComm_non_eComm.sku)
            {
                return BadRequest();
            }

            _context.Entry(eComm_non_eComm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!eComm_non_eCommExists(id))
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

        // POST: api/eComm_non_eComm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<eComm_non_eComm>> PosteComm_non_eComm(eComm_non_eComm eComm_non_eComm)
        {
            _context.Ecommerce.Add(eComm_non_eComm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GeteComm_non_eComm", new { id = eComm_non_eComm.sku}, eComm_non_eComm);
        }

        // DELETE: api/eComm_non_eComm/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteeComm_non_eComm(int id)
        {
            var eComm_non_eComm = await _context.Ecommerce.FindAsync(id);
            if (eComm_non_eComm == null)
            {
                return NotFound();
            }

            _context.Ecommerce.Remove(eComm_non_eComm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool eComm_non_eCommExists(int id)
        {
            return _context.Ecommerce.Any(e => e.sku == id);
        }
    }
}
