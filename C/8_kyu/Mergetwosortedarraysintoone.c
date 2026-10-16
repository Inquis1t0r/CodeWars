#include <stddef.h>

static int at(const int *arr, size_t len, int asc, size_t k)
{
    return asc ? arr[k] : arr[len - 1 - k];
}

size_t merge_arrays(
    size_t len_a, const int a[len_a],
    size_t len_b, const int b[len_b],
    int merged[len_a + len_b])
{
    int asc_a = len_a < 2 || a[0] <= a[len_a - 1];
    int asc_b = len_b < 2 || b[0] <= b[len_b - 1];
    size_t i = 0, j = 0, n = 0;

    while (i < len_a || j < len_b) {
        int v;
        if (j >= len_b || (i < len_a && at(a, len_a, asc_a, i) <= at(b, len_b, asc_b, j))) {
            v = at(a, len_a, asc_a, i++);
        } else {
            v = at(b, len_b, asc_b, j++);
        }
        if (n == 0 || merged[n - 1] != v) {
            merged[n++] = v;
        }
    }

    return n;
}
