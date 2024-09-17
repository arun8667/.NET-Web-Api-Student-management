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
    public class CollegeGetter : ICollegeGetter
    {
        private readonly CollegeDbContext _collegeDbContext;

        public CollegeGetter(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }
        public List<CollegeResponseModel> GetCollegeGetter(string Name)
        {
            var CollegeDetails = _collegeDbContext.College
                .Where(x => x.Name.Contains(Name))
                .Select(x => new CollegeResponseModel()
                {
                    Name = x.Name,
                    CollegeId = x.CollegeId,
                    Department = x.Department
                }).ToList();
            return CollegeDetails;
        }

    }
}
