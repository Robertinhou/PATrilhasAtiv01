/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex07
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int idade;
			string nome;
			Console.Write("Nome: ");
			
			nome = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.Write("Idade: ");
			idade = Convert.ToInt32(Console.ReadLine());
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}