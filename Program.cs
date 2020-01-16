using System;
using System.Collections.Generic;

namespace ProvaPOOPart1CSharp
{
    class Program
    {
		static void Main(string[] args)
		{
			Pessoa p1 = new Pessoa("João", 15);
			Pessoa p2 = new Pessoa("Leandro", 21);
			Pessoa p3 = new Pessoa("Paulo", 17);
			Pessoa p4 = new Pessoa("Jessica", 18);

			List<Pessoa> list = new List<Pessoa>();

			list.Add(p1);
			list.Add(p2);
			list.Add(p3);
			list.Add(p4);

			int aux = 0;
			string saux = " ";

			for (int i = 0; i < list.Count; i++) {
				if (list[i].Idade > aux)
				{					
					aux = list[i].Idade;
					saux = list[i].Nome;
										
				}				
			}
			Console.WriteLine(saux + " " + aux);

			Console.WriteLine(list.Count);

			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Idade < 18)
				{
				list.RemoveAt(i);
				}
			}

			Console.WriteLine(list.Count);

			for(int i = 0; i < list.Count; i++)
			{
				if (list[i].Nome == "Jessica")
				{
					Console.WriteLine(list[i].Idade);
				}
			}

		}
	}
}
