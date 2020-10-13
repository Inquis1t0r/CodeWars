using System.Text;

public static class Kata
{

    public static string greet() 
    {
      string mystery = "68 65 6c 6c 6f 20 77 6f 72 6c 64 21";
      return Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(mystery));
    }
}
