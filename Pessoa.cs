﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOOPart1CSharp
{
    public class Pessoa
    {

		public string Nome { get; set;}
		public int Idade { get; set; }


		public Pessoa(string nome, int idade)
		{
			this.Nome = nome;
			this.Idade = idade;
			
		}

		public Pessoa()
		{
		}
	}
}
