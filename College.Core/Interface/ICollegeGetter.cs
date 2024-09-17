using CollegeModel;

namespace College.Core.Interface
{
    public interface ICollegeGetter
    {
        List<CollegeResponseModel> GetCollegeGetter(string Name);
    }
}