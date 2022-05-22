using System; 

class Program {

    static void Main (string [] args) { 

   double a = double.Parse(Console.ReadLine());
   double x = a * a * a;
   double volume = ((4f/3f) * 3.14159) * x;
   Console.WriteLine($"VOLUME = {volume:0.000}");   

  }
}