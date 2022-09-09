using System;
class Program{  
  static void Main(string[] args){
  double a, b, c;
  string [] v = Console.ReadLine().Split(' '); 
  double x = double.Parse(v[0]);
  double y = double.Parse(v[1]);
  double z = double.Parse(v[2]);
  a = 0;
  b = 0;
  c = 0;
  if (x > y && x > z){
    a = x;
    if (y > z){
      b = y;
      c = z;
    }
    else{
      b = z;
      c = y;
    }                
  }
  else if (y > x && y > z){
    a = y;
    if ( x > z){
      b = x;
      c = z;
    } 
    else{
      b = z;
      c = x;
    }
  }
  else{
    a = z;
    if (x > y){
      b = x;
      c = y;
    } 
    else{
      b = y;
      c = x;
    }
  }            
  if (a >= b + c ){
    Console.WriteLine("NAO FORMA TRIANGULO");
  }
  else{
    if (a * a == b * b + c * c){
      Console.WriteLine("TRIANGULO RETANGULO");
    }
    else if ((a *a) > (b * b) + (c * c)){
      Console.WriteLine("TRIANGULO OBTUSANGULO");
    }
    else{
      Console.WriteLine("TRIANGULO ACUTANGULO");
    }
  }
  if (a == b && a == c){
    Console.WriteLine("TRIANGULO EQUILATERO");
  }
  else if (a == b || b == c || a == c){
    Console.WriteLine("TRIANGULO ISOSCELES");
    }
  }
} 