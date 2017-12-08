def simpleSort(arr):

    n = len(arr)

    for i in range(n):
        j = 0
        stop = n - i
        while j < stop - 1:
            if arr[j] > arr[j + 1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]
            j += 1
    return arr

if __name__ == '__main__':
	print( simpleSort([2,4,1,5] ) )
