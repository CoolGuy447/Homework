
def number_stats():
    num_list = []
    num = float(input("Enter a number: "))
    while num != -1:
        num_list.append(num)
        num = float(input("Enter a number: "))
    print("the average is: " + str(avg_of_numbers(num_list)))
    print("amount of positive numbers is: " + str(positive_number_count(num_list)))
    num_list.sort()
    print("sorted numbers: ")
    print(num_list)


def avg_of_numbers(num_list):
    total_sum = 0
    count = 0
    for item in num_list:
        total_sum += item
        count += 1
    return total_sum / count


def positive_number_count(num_list):
    count = 0
    for item in num_list:
        if item > 0:
            count += 1
    return count
