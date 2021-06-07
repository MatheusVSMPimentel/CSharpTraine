using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  Acumuladores();
		  SomadoresEacumuladores();
		  DivisoresDe3E4();
		  NumerosFatoriais();
		  FibonnaciImpressaoColunas();
	  }
		
		public static void Acumuladores(){
		  int total = 2; for (int i = 0; i < 5; i += 1) 
		{ 
		  total = total * 2; 
		}
		Console.WriteLine(total);
		int soma1pra1000 = 0;
		for (int i = 0; i < 1000; i += 1) 
		{
		  soma1pra1000 += 1; 
		  Console.Write(soma1pra1000 + "; ");
		}
		Console.WriteLine("");
		}
		
		public static void SomadoresEacumuladores(){
		  int somaSemMutiploDe3 = 0;
		int contadorExterno = 0;
	Console.WriteLine("");
		int[] multiploDe3 = new int[100];
		for(int i = 0; i < 100; i++)
		{
		  if(i % 3 == 0 && i != 0){
		    multiploDe3[contadorExterno] = i;
		    contadorExterno++;
		  }else{
		    somaSemMutiploDe3 += i;
		  }
		}
		Console.WriteLine("Total da soma 0 a 100 sem multiplos de 3: " + somaSemMutiploDe3);
		for(int i = 0; i < 100; i++){
		  if(multiploDe3[i] != 0){
		    Console.Write(multiploDe3[i]+"; ");}
		  }
		  Console.WriteLine("");
		}
		
		public static void DivisoresDe3E4(){
		  int[] divisiveisPor4, divisiveisPor3;
		  divisiveisPor3 = new int[20];
		  divisiveisPor4 = new int[20];
		  int contadorExterno4, contadorExterno3;
		  contadorExterno3 = contadorExterno4 = 0;
		  for(int i = 0 ; i <= 30; i++)
      {
        if(i > 0 && i%3 == 0)
        {
          divisiveisPor3[contadorExterno3] = i;
          contadorExterno3++;
          if(i%4 == 0){
          divisiveisPor4[contadorExterno4] = i;
          contadorExterno4++;
          }
        }
        else if(i > 0 && i%4 == 0)
        {
          divisiveisPor4[contadorExterno4] = i;
          contadorExterno4++;
        }
      }	
    Console.Write("Divisiveis Por 3: ");
    for(int i = 0; i < 20; i++){
		  if(divisiveisPor3[i] != 0)
		  {
		    Console.Write(divisiveisPor3[i]+"; ");
		  }
		  }
		Console.WriteLine("");
		Console.Write("Divisiveis Por 4: ");
		for(int i = 0; i < 20; i++){
		  if(divisiveisPor4[i] != 0){
		    Console.Write(divisiveisPor4[i]+"; ");
		  }
		  }
		  Console.WriteLine("");
		}
		
		public static void NumerosFatoriais()
		{
		  int contadorExterno = 0, resultadoFatoracaoAnterior = 1;
		  int[] fatoracaoResultados = new int[11];
		  while(contadorExterno < 11){
		    fatoracaoResultados[contadorExterno] = resultadoFatoracaoAnterior;
		    contadorExterno++;
		    resultadoFatoracaoAnterior = resultadoFatoracaoAnterior * contadorExterno;
		  }
		  Console.WriteLine("Fatorais de 0 a 10: ");
		  for(int i = 0; i < 11; i++){
		    Console.WriteLine("Fatorial de "+ i +": "+ fatoracaoResultados[i]);
		  } 
		  Console.WriteLine("");
		}
		
		public static void FibonnaciImpressaoColunas(){
		  int fibonacciUltimoResultado = 0, 
		  fibonacciResultadoAtual = 1, fibonacciResultadoTransicao = 0,
		  contadorExterno = 0;
		  int[] fibonacciLista = new int[20];
		  while(fibonacciUltimoResultado < 100)
		  {
		    fibonacciResultadoTransicao = fibonacciResultadoAtual;
		    fibonacciLista[contadorExterno] = fibonacciResultadoAtual;
		    fibonacciResultadoAtual = fibonacciUltimoResultado + fibonacciResultadoAtual;
		    fibonacciUltimoResultado = fibonacciResultadoTransicao;
		    contadorExterno++;
		  }
		  for(int i = 0; i < fibonacciLista.Length; i++)
		  {
		    if(fibonacciLista[i] != 0){
		      if(i > 0){
		        for(int row = 0; row < i; row++){
		          Console.Write(fibonacciLista[row] + "; ");
		        }
		      }
		      Console.WriteLine(fibonacciLista[i]);  
		    }
		  }
		  Console.WriteLine("");
		}
		
	}
}
