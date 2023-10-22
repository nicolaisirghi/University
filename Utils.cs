using System.Text.RegularExpressions;
using System.Xml;

namespace Student
{
    public class Utils
    {
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }


            string pattern = "^[A-Z][a-zA-Z]*$";

            return Regex.IsMatch(name, pattern);
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{8,15}$");
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        public static bool isValidGrupe(string value)
        {
            return Regex.IsMatch(value, @"^[A-Za-z\d]{4,6}$");
        }

        public static bool isValidAdress(string adress)
        {
            return Regex.IsMatch(adress, "^[A-za-z\\d-. /]{10,100}$");
        }
    }
}