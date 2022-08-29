using System; 
  class Program {
    static void Main (string [] args) { 
      string[] numeros = Console.ReadLine().Split();
      double[] convertidos = new double[3];
        for(int i=0; i<convertidos.Length; i++){
          convertidos[i] = double.Parse(numeros[i]);
  }
      double triangulo = (convertidos[0] * convertidos[2])/2;
      double circulo = (convertidos[2] * convertidos[2])*3.14159;
      double trapezio = ((convertidos[0] + convertidos[1])*convertidos[2])/2;
      double quadrado = convertidos[1] * convertidos[1];
      double retangulo = convertidos[0] * convertidos[1];
      Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
      Console.WriteLine($"CIRCULO: {circulo:0.000}");
      Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
      Console.WriteLine($"QUADRADO: {quadrado:0.000}");
      Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}