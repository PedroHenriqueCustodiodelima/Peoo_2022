a,b,c,d = map(int,input().split())
if(a+b>c and b+c>a and c+a>b):
  print("S")
elif (a+b>d and b+d>a and d+a>b):
  print("S")
elif (a+d>c and d+c>a and c+a>d):
  print("S")
elif (d+b>c and b+c>d and c+d>b):
  print("S")
else:
  print("N")