
def is_sorted_polyndrom(string):
    length = len(string)
    second_half = string[length // 2:]
    if length % 2 == 1:
        first_half = string[:length // 2 + 1]
    else:
        first_half = string[:length // 2]

    sorted_first_half = ''.join(sorted(first_half))
    sorted_second_half = ''.join(sorted(second_half, reverse=True))
    if not first_half == sorted_first_half:
        return False
    if not second_half == sorted_second_half:
        return False

    if not first_half == second_half[::-1]:
        return False
    return True
