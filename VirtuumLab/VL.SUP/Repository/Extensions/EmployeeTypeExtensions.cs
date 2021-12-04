using VLSUP.Views;

namespace VLSUP.Repository.Extensions
{
    public static class EmployeeTypeExtensions
    {
        public static FilterEmployeeType ToFilterEmployeeType(this EmployeeType type)
        {
            if (type.Title.ToLower().Contains("junior")) return FilterEmployeeType.Juniors;
            if (type.Title.ToLower().Contains("middle")) return FilterEmployeeType.Middles;
            return FilterEmployeeType.Seniors;
        }
    }
}
