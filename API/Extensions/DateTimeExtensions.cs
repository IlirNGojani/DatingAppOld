namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalcuateAge(this DateTime dob)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dob.Year;

            if (dob > today.AddYears(-age)) age--;

            return age;
        }
    }
}