using System; 
class Program{
  static void Main(string[] args) {
    string[] v = Console.ReadLine().Split(' ');
    if(v[0] == "1"){
      Console.WriteLine(1);
    }
    else if(v[1] == "1"){
      Console.WriteLine(2);
    }
    else if(v[2] == "1"){
      Console.WriteLine(3);
    }
    else{
      Console.WriteLine(4);
    }
  }
}