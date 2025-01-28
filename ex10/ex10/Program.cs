/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex10
{
	class Program
	{
		public static void Main(string[] args)
		{
			string pais;
			string estado;
			string cidade;
			string bairro;
			string rua;
			string numero;
			
			
			
			
			Console.Write("País: ");
			
			pais = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.Write("Estado: ");
			
			estado = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.Write("Cidade: ");
			
			cidade = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.Write("Bairro: ");
			
			bairro = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.Write("Rua: ");
			
			rua = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.Write("Número da casa: ");
			
			numero = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.WriteLine("Endereço: ");
				
			Console.WriteLine(rua + ", "+ numero + " - " + bairro + ". "+ estado + ", "+ pais);
			
			Console.WriteLine(estado + ", "+ pais);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}