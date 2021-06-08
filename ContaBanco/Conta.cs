using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using POOStart.Cliente;

namespace POOStart
{

public class Conta
	{
		public int numero;
    public Cliente titular;
    public double saldo;
    public int idade;
    
    public bool Saca(double valorASacar)
    {
      if(this.saldo >= valorASacar && valorASacar > 0 && this.idade > 13)
      {
        if(this.idade > 18)
        {
        this.saldo -= valorASacar;
        return true;
        } else if (valorASacar < 200)
        {
        this.saldo -= valorASacar;
        return true;
        } else 
        {
          return false;
        }
        
      }
      else
      {
        return false;
      }
    }
    
    public void Deposita(double valor)
    {
      this.saldo += valor;
    }
    
    public void Transfere(double valor, Conta destino)
    {
      if(this.Saca(valor))
      {
        destino.Deposita(valor);
      }
    }
    
	}
}
