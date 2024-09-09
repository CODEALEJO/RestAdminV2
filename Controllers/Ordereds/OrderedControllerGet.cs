using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderedController
    {
        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ordered>>> GetOrdereds()
        {
            return await _context.Ordereds.Include(i => i.Customer).Include(i => i.Table).ToListAsync();
        }

        // GET: api/Ordered/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ordered>> GetOrdered(int id)
        {
            var ordered = await _context.Ordereds.Include(i => i.Customer).Include(i => i.Table).FirstOrDefaultAsync(i => i.Id == id);
            if (ordered == null)
            {
                return NotFound();
            }

            return Ok(ordered);
        }


        // GET: api/Ordered/TopProducts?month=9
        [HttpGet("TopProducts")]
        public async Task<ActionResult<IEnumerable<Ordered>>> GetTopProducts(int month)
        {
            {
                var topProducts = await _context.OrderDetails
                    .Include(od => od.Product)
                    .Include(od => od.Ordered)
                        .ThenInclude(o => o.Invoices)
                    .Where(od => od.Ordered.Invoices
                        .Any(i => i.DateInvoice.Month == month)) // Verifica el mes en todas las fechas de las facturas
                    .GroupBy(od => new { od.Product.Id, od.Product.Name })
                    .Select(g => new
                    {
                        ProductId = g.Key.Id,
                        ProductName = g.Key.Name,
                        TotalQuantitySold = g.Sum(od => od.Quantity)
                    })
                    .OrderByDescending(g => g.TotalQuantitySold)
                    .ToListAsync();

                if (!topProducts.Any())
                {
                    return NotFound("No products found for the specified month.");
                }

                return Ok(topProducts);
            }
        }
    }
}