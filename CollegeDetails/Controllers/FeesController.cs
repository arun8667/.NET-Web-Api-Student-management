using College.Core.Implementation;
using College.Core.Interface;
using CollegeModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeesController : ControllerBase
    {
        private readonly IFeesCreator _feesCreator;
            public FeesController(IFeesCreator feesCreator)
        {
            _feesCreator = feesCreator;
        }

        // GET: api/<FeesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FeesController>
        [HttpPost]
        public void Post([FromBody] FeesRequestModel feesRequest)
        {
       
          _feesCreator.CreateFees(feesRequest);
        }

        // PUT api/<FeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
