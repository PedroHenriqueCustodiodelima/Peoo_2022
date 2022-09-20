using System;
class Program{
  static void Main(string[] args){
    int cont = 0, valor = 0;
    string codigo;
    while (cont < 3){
      codigo = Console.ReadLine();
      if(codigo[0] == '-' && codigo[1] == '-' && codigo[2] == '*'){
        valor++;
      }
      else{
        if (codigo[0] == '-' && codigo[1] == '*' && codigo[2] == '-'){
          valor = valor + 2;
        }
        else{
          if(codigo[0] == '-' && codigo[1] == '*' && codigo[2] == '*'){
            valor = valor + 3;
          }
          else{
            if(codigo[0] == '*' && codigo[1] == '-' && codigo[2] == '-'){
              valor = valor + 4;
            }
            else{
              if (codigo[0] == '*' && codigo[1] == '-' && codigo[2] == '*'){
                valor = valor + 5;
              }
              else{
                if (codigo[0] == '*' && codigo[1] == '*' && codigo[2] == '-'){
                  valor = valor + 6;
                }
                else{
                  if (codigo[0] == '*' && codigo[1] == '*' && codigo[2] == '*'){
                    valor = valor + 7;
                  }
                  else{
                    if (codigo[0] == '-' && codigo[1] == '-' && codigo[2] == '-'){
                      valor = valor + 0;
                    }
                    else{
                      Console.WriteLine(valor);
                      valor = 0;
                      cont++;
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
}