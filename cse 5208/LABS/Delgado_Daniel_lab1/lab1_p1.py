from datetime import date

name = input('What is your name?: ')
age = int(input('What is your age?: '))

year = date.today()
DOB = year.year - age

print('Name & DOB:', name, DOB)