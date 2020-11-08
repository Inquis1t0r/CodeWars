String chromosome_check(String sperm) {
  String result = ''; 
  
  if(sperm == "XX")
    result = "Congratulations! You're going to have a daughter.";
  else
    result = "Congratulations! You're going to have a son.";
  
  return result;
}
