public static class Kata
    {
        public static string bonus_time(int salary, bool bonus)
        {
          return "$" + (bonus == true ? (salary * 10).ToString() : salary.ToString());
        }
    }
