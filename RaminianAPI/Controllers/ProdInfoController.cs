using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RaminianAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RaminianAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdInfoController : Controller
    {
        private readonly ApiDBContext _context;

        public ProdInfoController(ApiDBContext context)
        {
            _context = context;
        }

        // GET: api/eComm_non_eComm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdInfo>>> GetEcommerce()
        {
            //return await _context.Ecommerce.ToListAsync();
            /* var str = "SELECT P.ProductID, P.SKU, P.Description, pwi.WareID, W.WareName AS [Warehouse], PWI.Location, sbw.Instock AS [InStock] FROM dbo.Products AS P " +
                         " LEFT JOIN dbo.Product_WareInfo AS PWI " +
                         " ON PWI.ProductID = P.ProductID " +
                         " LEFT JOIN dbo._Warehouses AS W ON W.WareID = PWI.WareID " +
                         " LEFT JOIN dbo.StockBalance_Ware AS SBW ON SBW.ProductID = P.ProductID AND SBW.WareID = PWI.WareID " +
                         " WHERE PWI.WareID IS NOT null";*/

            var str = "SELECT P.ProductID, P.SKU, P.Description, pwi.WareID, W.WareName AS [Warehouse], PWI.Location, sbw.Instock AS [InStock] FROM dbo.Products AS P LEFT JOIN dbo.Product_WareInfo AS PWI  ON PWI.ProductID = P.ProductID LEFT JOIN dbo._Warehouses AS W ON W.WareID = PWI.WareID LEFT JOIN dbo.StockBalance_Ware AS SBW ON SBW.ProductID = P.ProductID AND SBW.WareID = PWI.WareID WHERE PWI.WareID IS NOT null";
            return await _context.ProdInfo.FromSqlRaw(str)
            .ToListAsync();
            //return await _context.Database.ExecuteSqlCommand(str);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdInfo(int id, ProdInfo PI)
        {
            if (id != PI.ProductID)
            {
                return BadRequest();
            }

            _context.Entry(PI).State = EntityState.Modified;

            try
            {
                var myParams = new[] {
                new SqlParameter("@ProductID", SqlDbType.Int)
                {
                  Direction = ParameterDirection.Input,
                  Value = PI.ProductID, DbType = DbType.Int32
                },
                new SqlParameter("@WareID", SqlDbType.Int)
                {
                  Direction = ParameterDirection.Input,
                  Value = PI.WareID, DbType = DbType.Int32
                },
                new SqlParameter("@Location", SqlDbType.NVarChar, 20)
                {
                  Direction = ParameterDirection.Input,
                  Value = PI.Location
                  , DbType = DbType.String
                }

              };
                //string sql = "EXEC SalesLT.Product_Get @ProductID";

                //_context.Database.ExecuteSqlRaw("EXEC dbo.ProdInfo_Ware_Update @ProductID,@WareID,@MinStock,@MaxStock,@Location", myParams);
                _context.Database.ExecuteSqlRaw("EXEC dbo.ProdInfo_Ware_Update @ProductID , @WareID , @Location", myParams);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }
    }
}
