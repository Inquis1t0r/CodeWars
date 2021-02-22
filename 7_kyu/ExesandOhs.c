#include <stdbool.h>
#include <ctype.h>

bool xo (const char* str)
{
  int i,j;
  
  for (i=0; str[i]; str[i]=='x' || str[i]=='X' ? i++ : *str++);
  for (j=0; str[j]; str[j]=='o' || str[j]=='O'? j++ : *str++);

  return i == j;
}
