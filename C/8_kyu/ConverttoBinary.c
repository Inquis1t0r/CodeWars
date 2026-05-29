unsigned long long to_binary(unsigned short num)
{
    unsigned long long d = 0ull;
    unsigned long long placeValue = 1ull;

    while (num > 0) {
        d += (num % 2) * placeValue;
        placeValue *= 10ull;
        num /= 2;
    }

    return d;
}
