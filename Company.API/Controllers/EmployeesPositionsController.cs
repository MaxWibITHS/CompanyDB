using System.Security.Cryptography.X509Certificates;
using Company.Common.DTOs;
using Company.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesPositionsController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeesPositionsController(IDbService db)
        {
            _db = db;
        }

        // POST api/<EmployeesPositionsController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeePositionDTO dto)
        {
            try
            {
                if (!_db.Add<EmployeePosition, EmployeePositionDTO>(dto)) return Results.BadRequest();
                if (await _db.SaveChangesAsync()) return Results.NoContent();
            }
            catch { }
            
            return Results.BadRequest();

            }

        // DELETE api/<EmployeesPositionsController>/5
        [HttpDelete]
        public async Task<IResult> Delete(EmployeePositionDTO dto)
        {
            try
            {
                if (!_db.Delete<EmployeePosition, EmployeePositionDTO>(dto)) return Results.NotFound();
                if (await _db.SaveChangesAsync()) return Results.NoContent();
            }
            catch { }
            
            return Results.BadRequest("Delete not complete");
        }

    }
}
    

