/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace e04
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool check;
			string escolha;
			Console.WriteLine("sim ou não?");
			
			escolha = Console.ReadLine();
			
			check = (escolha == "sim" || escolha == "Sim" || escolha == "SIM") ? true : false;
			
			Console.WriteLine(check);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}