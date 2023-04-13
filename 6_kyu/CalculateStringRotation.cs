public class CalculateStringRotation
{
  public static int? ShiftedDiff(string first, string second)
  {
      if (first.Length != second.Length)
      {
          return null;
      }

      string combined = first + first;
      for (int i = 0; i < first.Length; i++)
      {
          string substring = combined.Substring(i, first.Length);
          if (substring == second)
          {
              return i;
          }
      }

      return null;
  }

}
