#1
import pandas as pd 
import numpy as np
#11
from matplotlib import pyplot as plt
#12
import seaborn as sns

#2
df = pd.read_csv('Car_loan.csv') #loads csv file in dataframe

#3
export_csv = df.to_csv(r'out.csv') #exports csv file

#4
df_info = df.info()
print(df_info) #prints dataframe information

#5
df = df.rename(columns={'Starting Balance': 'starting_balance', 'Interest Paid': 'interest_paid', 'Principal Paid': 'principal_paid', 'New Balance': 'new_balance'}) #renames columns
df = df.drop(['term', 'Repayment'], axis=1) #eliminates term and repayment columns


#6
interest_missing = df['interest_paid'].isna() #confirms if interest was paid or not using false or true

#7
df.loc[interest_missing, 'interest_paid'] = 0 #adds entry to interest_missing
print(interest_missing) #prints the missing interest

#8
total_interest_paid = df['interest_paid'].sum() #sum of interest paid
print(total_interest_paid) #prints the total interest paid

#9
column_sum = df.sum(axis=1) #adds columns
print(column_sum) #prints sum of columns

#10
numpy_array = df.to_numpy() #converts dataframe to numpy arrays 
print(numpy_array) #prijnts numpy arrays

#13
df = pd.read_csv('out.csv') #loads out.csv data

#14
month_number = df.loc[:,'Month'].values #locates month_number array
interest_paid = df.loc[:,'Interest Paid'].values #locates intereest_paid array
principal_paid = df.loc[:,'Principal Paid'].values #locates principal_paid array
print(month_number)
print(interest_paid)
print(principal_paid)

#15
print(type('month_number')) # checks the data type of month_number array

#16
plt.plot(month_number, interest_paid) #plots months vs interest paid

#17
plt.plot(month_number, principal_paid) #plots months vs principal paid

#18
#plt.style.available

#19
plt.style.use('classic') #uses clasic plot graph

#20
plt.style.use('fivethirtyeight') # uses fivethirtyeight plot graph

#21
plt.style.use('seaborn') # uses seaborn plot graph

#22
plt.legend("center right") #add legends to graph

#24
plt.ylabel('Dollars') # creates Dollars as y label
plt.xlabel('Months') # creates Months as x label 

