using System;
class HelloWorld {
  static void Main(string[] args)
  {
      int lado1, lado2, area, perimetro;
      Console.WriteLine("Entre com o primeiro lado:");
      lado1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Entre com o segundo lado:");
      lado2 = int.Parse(Console.ReadLine());
      area = lado1 * lado2;
      perimetro = lado1 + lado1 + lado2 + lado2;
      Console.WriteLine("Valores entrados: {0} e {1} ", lado1, lado2);
      Console.WriteLine("area = {0} perimetro {1}", area, perimetro);
    Console.ReadKey();
    
  }
}
