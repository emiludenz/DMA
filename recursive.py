"""
"The power of recursion evidently lies in the possibility of defining an 
infinite set of objects by a finite statement. In the same manner, 
an infinite number of computations can be described by a finite 
recursive program, even if this program contains no explicit repetitions."
"""

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
