using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CompanyClassController : ControllerBase
    {
        private readonly IDbService _db;
        public CompanyClassController(IDbService db)
        {
            _db = db;
        }

        // GET: api/<CompanyClassController> 
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<CompanyClass, CompanyClassDTO>();
       

        // GET api/<CompanyClassController>/
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetAsync<CompanyClass, CompanyClassDTO>(id);
      

        // POST api/<CompanyClassController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyClassDTO dto) => await _db.HttpPostAsync<CompanyClass, CompanyClassDTO>(dto);
       

        // PUT api/<CompanyClassController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyClassDTO dto) => await _db.HttpPutAsync<CompanyClass, CompanyClassDTO>(dto, id);
        

        // DELETE api/<CompanyClassController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<CompanyClass>(id);
        
    }
}
