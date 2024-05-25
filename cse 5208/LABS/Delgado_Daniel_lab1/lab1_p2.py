n = int(input('Input a whole number: '))

def get_divisors(n):
    result = []
    for i in range(1, int(n / 2) + 1):
        if n % i == 0:
            result.append(i)
    return result

print('Divisor result: ', (get_divisors(n)))
