int other_angle(int a, int b) {
    int sumOfInteriorAngles = 180;
    int sumOfTwoAngles = a + b;
    //  <----  hajime!
    return sumOfInteriorAngles - sumOfTwoAngles;
}
