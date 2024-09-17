using CollegeModel;

namespace College.Core.Interface
{
    public interface ICollegeCreator
    {
        public void CreateCollege(CollegeRequestModel collegeRequest);
        
    }
}