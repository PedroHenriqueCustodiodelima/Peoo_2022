def check(PM,  PN, QM, QN):
	return (PM * QN == PN * QM)

entrada = input()
A,B,C,D = entrada.split()
A = int(A)
B = int(B)
C = int(C)
D = int(D)

if check(A, B, C, D) or check(A, D, B, C) or check(A, C, D, B):
	print("S")
else:
	print("N")