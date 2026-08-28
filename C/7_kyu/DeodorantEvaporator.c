int evaporator(double content, double evap_per_day, double threshold) {
    double limit = content * threshold / 100.0;
    int days = 0;

    while (content > limit) {
        content *= (1 - evap_per_day / 100.0);
        days++;
    }

    return days;
}
