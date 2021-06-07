using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
delta = bb - 4a*c; a1 = (-b + raiz(delta)) / (2 * a); a2 = (-b - raiz(delta)) / (2 * a);
Crie um programa com três variáveis inteiras, `a, b, c`, com quaisquer valores. Depois crie 3 variáveis double, `delta, a1, a2`, com a fórmula anterior.

Imprima `a1` e `a2` em um MessageBox.

Dica: Para calcular raiz quadrada, use `Math.Sqrt(variavel)`. Não se esqueça que não podemos calcular a raiz quadrada de números negativos.
*/
namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int a, b,c;
		  a= 3;
		  b= -5;
		  c= -3;
		  double delta, x1, x2;
		  delta = b ^ 2 - 4 * a * c;
		  if(delta < 0){
		    Console.WriteLine("Delta negativo Raizes Negativas Não Pertencem ao conjunto dos Numeros Reais |R");
		  }
		  else{
		    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
		    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
		    Console.WriteLine("Resultado de x1: "+ x1);
		    Console.WriteLine("Resultado de x2: "+ x2);
		  }
		}
	}
}
