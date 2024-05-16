
def pythagorean_triplet_by_sum(summary):
    end = False
    a = 1
    b = 1
    c = summary - 2
    while not end:
        if check_pythagorean_numbers(a, b, c):
            print(f"triplets:{a}, {b}, {c}")
        if b < (summary // 2):
            b += 1
            c = summary - a - b
        else:
            a += 1
            b = a
            c = summary - a - b
        if a > c and a == b:
            end = True


def check_pythagorean_numbers(a, b, c):
    if (a ** 2) + (b ** 2) == (c ** 2) and a < b < c:
        return True
    else:
        return False
