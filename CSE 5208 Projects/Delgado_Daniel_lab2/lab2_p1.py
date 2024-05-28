import csv

with open("students.csv", "r") as students:
	read_file = csv.reader(students) #assigns csv file to read_file
	
	for s in read_file:
		 print(f'{s[0]}     {s[1]}      {s[2]}      {s[3]}') #prints each word in the csv file 
