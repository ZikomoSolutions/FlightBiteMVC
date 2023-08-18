namespace FlightBite.MVC.Utilities
{
    public class UiUtils
    {

        public static string IsActive(string path ,string route)
        {
            return path.EndsWith(route) ? "active__menu" : "";

        }
    }
}
