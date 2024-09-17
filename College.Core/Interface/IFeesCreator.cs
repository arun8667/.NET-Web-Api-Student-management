using CollegeModel;

namespace College.Core.Interface
{
    public interface IFeesCreator
    {
        void CreateFees(FeesRequestModel feesRequest);
    }
}