using College.Core.Interface;
using CollegeDetails.Core.Implementation;
using CollegeDetails.Infra.Migrations;
using CollegeModel;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly ICollegeCreator _collegeCreator;
        private readonly ICollegeGetter _collegeGetter;
        private readonly ICollegeUpdator _collegeUpdator;
        private readonly ICollegeDeletor _collegeDeletor;

        //private object _collegeGetter;

        public CollegeController(ICollegeCreator collegeCreator, ICollegeGetter collegeGetter, 
            ICollegeUpdator collegeUpdator, ICollegeDeletor collegeDeletor)
        {
            _collegeCreator = collegeCreator;
            _collegeGetter = collegeGetter;
            _collegeUpdator = collegeUpdator;
            _collegeDeletor = collegeDeletor;
        }






        // GET: api/<CollegeController>
        [HttpGet]
        //public IActionResult Get()
        //{
        //    List<CollegeResponseModel> colleges = new List<CollegeResponseModel>();
        //    colleges = _collegeCreator.ToList();
        //    return( Ok(colleges));
        //}

        public CollegeResponseModel GetName(string name)
        {
            var getData = _collegeGetter.GetCollegeGetter(name);
            return new CollegeResponseModel
            {
                StatusCode = getData != null ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.NoContent,
                Data = getData
            }; 

        }

        // GET api/<CollegeController>/5
        [HttpGet("{id}")]
        

        // POST api/<CollegeController>
        [HttpPost]
        public void Post([FromBody] CollegeRequestModel collegeRequest)
        {
            _collegeCreator.CreateCollege(collegeRequest);
        }                    

        // PUT api/<CollegeController>/5
        [HttpPut("{id}")]
        public void Put(int collegeId, [FromBody] CollegeRequestModel collegeRequest)
        {
            _collegeUpdator.UpdateCollege(collegeId, collegeRequest);
        }

        // DELETE api/<CollegeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _collegeDeletor.DeleteCollege(id);
        }
    }
}
