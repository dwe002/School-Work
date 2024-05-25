import math

deg = int(input('Input an angle degree'))
rad = math.radians(deg)

print('cos: ', math.cos(rad))
print('sin: ', math.sin(rad))
print('tan: ', math.tan(rad))

def quad(deg):

    if deg <= 90:
        angle = 'quadrant 1'
    else:
        if deg <= 180:
            angle = 'quadrant 2'
        else:
            if deg <= 270:
                angle = 'quadrant 3'
            else:
                if deg <= 360:
                    angle = 'quadrant 4'

    return angle

    
print('Angle is in ', quad(deg))

print('Radian: ', rad)