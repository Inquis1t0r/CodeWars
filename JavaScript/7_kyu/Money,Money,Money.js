function calculateYears(principal, interest, tax, desired) {
    // your code
      if (principal === desired) {
        return 0;
    }

    let years = 0;

    while (principal < desired) {
        const interestEarned = principal * interest;
        const taxPaid = interestEarned * tax;
        principal += interestEarned - taxPaid;
        years++;
    }

    return years;
}
