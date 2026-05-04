#include <string.h>
// Write to `outp`, nul-terminate it, and return it
char *get_middle(char outp[3], const char *inp)
{
    //*outp = '\0';
    int len = strlen(inp);

    if (len % 2 != 0) {
        outp[0] = inp[len / 2];
        outp[1] = '\0';
    } else {
        outp[0] = inp[(len / 2) - 1];
        outp[1] = inp[len / 2];
        outp[2] = '\0';
    }
    return outp;
}
