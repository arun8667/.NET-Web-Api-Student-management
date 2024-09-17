using College.Core.Interface;
using College.Infra.Table;
using CollegeDetails.Infra.DataContext;
using CollegeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Core.Implementation
{
    public class FeesCreator : IFeesCreator
    {
        private readonly CollegeDbContext _collegeDbContext;

        public FeesCreator(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public void CreateFees(FeesRequestModel feesRequest)
        {
            var Fees = new FeesTable()
            {
                CollegeId = feesRequest.CollegeId,
                Fees = feesRequest.Fees,

            };
            _collegeDbContext.Fees.Add(Fees);
            _collegeDbContext.SaveChanges();


        }
    }
}
