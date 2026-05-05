#include <stdbool.h>
#include <regex.h>  
#include <stdio.h>

bool validate_pin(const char *pin) {

    //  <----  hajime!
    int len = strlen(pin);
    if(len != 4 || len != 6){
      return false;
    }
    regex_t regex;
    const char *pattern = "^([0-9]{4}|[0-9]{6})$"; 
  
    if (regcomp(&regex, pattern, REG_EXTENDED) != 0) {
      fprintf(stderr, "Failed to compile regex\n");
      return false;
    }
    int match = regexec(&regex, pin, 0, NULL, 0);
    regfree(&regex);
    return match == 1 ? true : false;

}
