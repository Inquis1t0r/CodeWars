char* whatday(int num) {
    // <---- hajime!
    if (num < 1 || num > 7) return "Wrong, please enter a number between 1 and 7";
    char *days[] = {
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    };
    return days[num - 1];
}
