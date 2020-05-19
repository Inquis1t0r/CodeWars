public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    // TODO: complete

  int index = url.IndexOf("#");
  if (index > 0)
      url = url.Substring(0, url.IndexOf("#"));
      
      return url;
  }
}
