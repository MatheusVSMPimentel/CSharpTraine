using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using POOStart.Cliente;
using POOStart.Conta;

namespace POOStart
{
  public class Program
	  {
	    public static void Main(string[] args)
	    {
	    Cliente victor = new Cliente();
      victor.nome = "victor";
      Conta umaConta = new Conta();
      umaConta.titular = victor;
      umaConta.titular.rg = "12345678-9";
      Console.WriteLine(umaConta.titular.nome);
      Console.WriteLine(victor.rg);
      if(umaConta.Saca(2000.0))
      {
      Console.WriteLine("Saque realizado com sucesso");
      }
      else
      {
      Console.WriteLine("Saque não realizado com sucesso verifique as condições da conta");
      }
	  }
	}
}
