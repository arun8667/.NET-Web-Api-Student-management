using College.Core.Interface;
using CollegeDetails.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Core.Implementation
{
    public class CollegeDeletor : ICollegeDeletor
    {
        private readonly CollegeDbContext _collegeDbContext;

        public CollegeDeletor(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public void DeleteCollege(int clgid)
        {
            var collegeDetails = _collegeDbContext.College
                .First(x => x.CollegeId == clgid);


            _collegeDbContext.College.Remove(collegeDetails);
            _collegeDbContext.SaveChanges();


        }
    }
}
