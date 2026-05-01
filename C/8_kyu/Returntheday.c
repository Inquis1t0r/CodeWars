char* whatday(int num) {
    if(num > 7 || num < 0){ return "Wrong, please enter a number between 1 and 7";}
    // <---- hajime!
    char *days[7] = {
        "Sunday",
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday"
    };
  return days[num+1];
}
