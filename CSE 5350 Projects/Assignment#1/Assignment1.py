import cmath #use python math library

#user inputs
a = float(input('a = '))
b = float(input('b = '))
c = float(input('c = '))

#determinant equation for soultion
d = (b * b) - (4 * a * c)

#display no solution if variable a or c are zero
if a == 0 or c == 0:
    print('No Solution')
    
#display both outcomes of quadratic formula depending on determinant
elif d == 0:
    root1 = -b / (2 * a)
    root2 = -b / (2 * a)
    print('root 1: ', root1)
    print('root 2: ', root2)
elif d > 0:
    root1 = (-b + cmath.sqrt((b * b) - (4 * a * c))) / (2 * a)
    root2 = (-b - cmath.sqrt((b * b) - (4 * a * c))) / (2 * a)
    print('root 1: ', root1)
    print('root 2: ', root2)
elif d < 0:
    root1 = -b / (2 * a)
    root2 = cmath.sqrt(-d) / (2 * a)
    print('root 1: ', root1)
    print('root 2: ', root2)
            




        
