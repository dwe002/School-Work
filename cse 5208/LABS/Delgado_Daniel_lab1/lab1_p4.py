arr = [1, 3, 5, 7, 9]

def find_cummulative_sum(arr):
    arr2 = []
    length = len(arr)
    arr2 = [sum(arr[0:x:1]) for x in range(0, length+1)]
    return arr2[1:]
 
print ('The cumulative sum of', arr, 'is', find_cummulative_sum(arr))