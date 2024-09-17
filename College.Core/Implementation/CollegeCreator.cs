//using College.Core.Interface;
using College.Core.Interface;
using CollegeDetails.Infra.DataContext;
using CollegeDetails.Infra.Table;
using CollegeModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails.Core.Implementation
{
    public class CollegeCreator : ICollegeCreator
    {
        private readonly CollegeDbContext _collegeDbContext;

        public CollegeCreator(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

     

        public void CreateCollege(CollegeRequestModel collegeRequest)
        {
            var college = new CollegeTable()
            {
                CollegeId = collegeRequest.CollegeId,
                Name = collegeRequest.Name,
                Department = collegeRequest.Department,



            };

            _collegeDbContext.College.Add(college);
            _collegeDbContext.SaveChanges();


        }

   
    }
}
