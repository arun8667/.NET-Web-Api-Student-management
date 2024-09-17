using CollegeModel;

namespace College.Core.Interface
{
    public interface ICollegeUpdator
    {
        void UpdateCollege(int collegeId, CollegeRequestModel collegeRequestModel);
    }
}