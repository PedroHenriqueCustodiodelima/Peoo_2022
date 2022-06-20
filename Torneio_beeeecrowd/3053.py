def movi(pos_atual, mov):
  if mov == 1:
    valor1, valor2 = "A", "B"
  elif mov == 2:
    valor1, valor2 = "B", "C"
  elif mov == 3:
    valor1, valor2 = "A", "C"

  if pos_atual == valor1:
    return valor2
  elif pos_atual == valor2:
    return valor1
  else:
    return pos_atual
  
a = int(input())
pos_atual = input()

for i in range(a):
  mov = int(input())
  pos_atual = movi(pos_atual, mov)
print(pos_atual)