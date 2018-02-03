using System.Linq;

namespace MarsRoverkata
{
    public static class Extensions
    {

        public static bool IsIn<T>(this T source, params T[] targets)
        {
            if (targets.Contains(source))
            {
                return true;
            }
            return false;
        }
    }
}
