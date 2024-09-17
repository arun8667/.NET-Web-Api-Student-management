using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CollegeModel
{
    public class CollegeResponseModel
    {
        
        public int CollegeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<CollegeResponseModel>? Data { get; set; }
    }
}
