def modulus(n):
	if type(n) == int :
		return n % 2
	else:
		return -1

if __name__ == '__main__':
	print( modulus(5.1) )
	print( modulus(5) )
