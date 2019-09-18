int find_short(std::string str)
{
  string tmpCurrent = "";
  string tempShortest = str;
  
  for(int i=0; i < (int)str.length(); i++)
  {

    if(str[i] != ' ')
    {
        tmpCurrent += str[i];
    }
    else
    {
        if(tmpCurrent.length() < tempShortest.length())
            tempShortest=tmpCurrent;
        tmpCurrent = "";
    }
  }
  if(tmpCurrent != "")
{
    if(tmpCurrent.length() < tempShortest.length())
        tempShortest=tmpCurrent;
}
  
  return tempShortest.length();
}
