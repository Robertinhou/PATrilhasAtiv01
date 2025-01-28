/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex09
{
	class Program
	{
		public static void Main(string[] args)
		{
			string palavra;
			Console.WriteLine("Digite uma palavra: ");
			
			palavra = Console.ReadLine();
			
			Console.WriteLine("A palavra tem: "+ palavra.Length + " letras");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}