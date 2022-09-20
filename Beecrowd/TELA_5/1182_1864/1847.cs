using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int temp1 = int.Parse(v[0]);
    int temp2 = int.Parse(v[1]);
    int temp3 = int.Parse(v[2]);
    int a = temp1;
    int b = temp2;
    int c = temp3;
      if(a > b){
        if(c >= b){
          Console.WriteLine(":)");
        }
        else{
          if(b - c < a - b){
            Console.WriteLine(":)");
          }
          else{
            Console.WriteLine(":(");
          }
        }
      }
    else{
      if(a < b){
        if(c <= b){
          Console.WriteLine(":(");
        }
        else{
          if(c - b < b - a){
            Console.WriteLine(":(");
          }
          else{
            Console.WriteLine(":)");
          }
        }
      }
      else{
        if(c > b){
          Console.WriteLine(":)");
        }
        else{
          Console.WriteLine(":(");
        }
      }
    }
  }
}