def RecT(n):
    # Gives the number times itself
    if n < 1:
        return 1
    else:
        return R1(n-1) + R1(n-1)

def RecFac(n):
    # Give us the factorial of a number
    if n < 1:
	return 1
    else:
	return n *R(n-1)
