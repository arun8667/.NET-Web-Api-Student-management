using College.Core.Interface;
using CollegeDetails.Infra.DataContext;
using CollegeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Core.Implementation
{
    public class CollegeUpdator : ICollegeUpdator
    {
        private readonly CollegeDbContext _collegeDbContext;

        public CollegeUpdator(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public void UpdateCollege(int collegeId, CollegeRequestModel collegeRequestModel)
        {
            var College = _collegeDbContext.College
                .Where(x => x.CollegeId == collegeId).FirstOrDefault();

            if (College != null)
            {

                College.Name = collegeRequestModel.Name;
                College.Department = collegeRequestModel.Department;
            }
            _collegeDbContext.SaveChanges();
        }

    }
}
