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
    public class ProductPhotoesController : ControllerBase
    {
        private readonly ApiDBContext _context;

        public ProductPhotoesController(ApiDBContext context)
        {
            _context = context;
        }

        // GET: api/ProductPhotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPhoto>>> GetProductPhoto()
        {
            return await _context.ProductPhoto.ToListAsync();
        }

        // GET: api/ProductPhotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPhoto>> GetProductPhoto(Guid id)
        {
            var productPhoto = await _context.ProductPhoto.FindAsync(id);

            if (productPhoto == null)
            {
                return NotFound();
            }

            return productPhoto;
        }

        // PUT: api/ProductPhotoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductPhoto(Guid id, ProductPhoto productPhoto)
        {
            if (id != productPhoto.FileID)
            {
                return BadRequest();
            }

            _context.Entry(productPhoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductPhotoExists(id))
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

        // POST: api/ProductPhotoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPhoto>> PostProductPhoto(ProductPhoto productPhoto)
        {
            _context.ProductPhoto.Add(productPhoto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductPhoto", new { id = productPhoto.FileID }, productPhoto);
        }

        // DELETE: api/ProductPhotoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductPhoto(Guid id)
        {
            var productPhoto = await _context.ProductPhoto.FindAsync(id);
            if (productPhoto == null)
            {
                return NotFound();
            }

            _context.ProductPhoto.Remove(productPhoto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductPhotoExists(Guid id)
        {
            return _context.ProductPhoto.Any(e => e.FileID == id);
        }
    }
}
