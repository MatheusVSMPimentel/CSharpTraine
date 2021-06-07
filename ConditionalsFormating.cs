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
		BancoTeste(); 
		NotaFiscalCalculadora();
		}
		
		public static void NotaFiscalCalculadora(){
		  /*
		  Se o valor for menor ou igual a 999, o imposto deve ser de 2%
      Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5%
      Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8%
      Se for maior ou igual a 7000, o imposto deve ser de 3%
      */
		  double valorDaNotaFiscal;
		  Console.Write("Insira o valor da nota: ");
		  valorDaNotaFiscal = Convert.ToInt32(Console.ReadLine());
		  if(valorDaNotaFiscal <= 0){
		    Console.WriteLine("Valor de Nota Fiscal Incorreto");
		  }else if (valorDaNotaFiscal <= 999 && valorDaNotaFiscal >= 1 ) {
		    Console.WriteLine("Valor do imposto sobre a nota: " + valorDaNotaFiscal*0,02);
		    Console.WriteLine("Valor dos produtos com imposto descontados: " + valorDaNotaFiscal*0,98);
		  } else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999 ) {
		    Console.WriteLine("Valor do imposto sobre a nota: " + valorDaNotaFiscal*0,025);
		    Console.WriteLine("Valor dos produtos com imposto descontados: " + valorDaNotaFiscal*0,975);
		  } else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999) {
		    Console.WriteLine("Valor do imposto sobre a nota: " + valorDaNotaFiscal*0,028);
		    Console.WriteLine("Valor dos produtos com imposto descontados: " + valorDaNotaFiscal*0,972);
		  } else {
		    Console.WriteLine("Valor do imposto sobre a nota: " + valorDaNotaFiscal*0,03);
		    Console.WriteLine("Valor dos produtos com imposto descontados: " + valorDaNotaFiscal*0,97);
		  }
		  
		}
		
		public static void BancoTeste(){
		  double taxa, saldo, valorSaque; 
		  saldo = 100.0;
		  valorSaque = 10.0;
		  if (saldo >= valorSaque) 
		  { 
		    saldo -= valorSaque; 
		    Console.WriteLine("Saque realizado com sucesso"); 
		  }
		  else 
		  { 
		    Console.WriteLine("Saldo Insuficiente"); 
		  } 
		  saldo = 5.0;
		  valorSaque = 10.0; 
		  if (saldo >= valorSaque) 
		  { 
		    saldo -= valorSaque;
		    Console.WriteLine("Saque realizado com sucesso"); 
		    
		  } 
		  else 
		  {
		    Console.WriteLine("Saldo Insuficiente");
		  }
		  
		  if (saldo < 1000) {
		    taxa = 0.01; 
		    
		  } else if (saldo <= 5000) {
		    taxa = 0.05; 
		    
		  } else { 
		    taxa = 0.1; 
		  }
		  saldo = 500.0; if (saldo < 0.0) { 
		    Console.WriteLine("Você está no negativo!"); 
		    
		  } else if (saldo < 1000000.0) {
		    Console.WriteLine("Você é um bom cliente"); 
		    
		  } else {
		    Console.WriteLine("Você é milionário!"); 
		    
		  } 
		}
	}
}
