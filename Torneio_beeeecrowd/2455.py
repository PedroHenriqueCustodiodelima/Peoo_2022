a = 0
p1, c1, p2, c2  = map(int, input().split())
valor = c1 * p1
valor1 = c2 * p2
if valor == valor1:
  print("0")
elif valor >= valor1:
  print("-1")
elif valor1 >= valor:
  print("1")