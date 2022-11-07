using System; 
class Program{
  static void Main(string[] args) { 
    double[,] x = new double[12,12];
    double total = 0;
    char tipo = char.Parse(Console.ReadLine());    
    for(int i = 0; i < 12; i++){
      for (int j = 0; j < 12; j++){
        x[i, j] = double.Parse(Console.ReadLine());
      }
    }    
    for (int i = 0; i < 12; i++){
      for (int j = 0; j < i; j++){
        total += x[j,i]; 
      }
    }         
    if (tipo == 'S'){
      Console.WriteLine("{0:F1}",total);
    }
    else if (tipo == 'M'){ 
      Console.WriteLine("{0:F1}",total/66.0f);
    }
  }
}