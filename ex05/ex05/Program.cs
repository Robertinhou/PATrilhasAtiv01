/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex05
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			char sexo;
			
			Console.WriteLine("Masculino ou Feminino (F ou M):");
			
			sexo = Convert.ToChar(Console.ReadLine());
			
			Console.WriteLine(sexo);
			
			string result = (sexo.Equals('F') || sexo.Equals('f') || sexo.Equals('M') || sexo.Equals('m')) ? "Boa Rodolfo" : "Faz o trem direito Rodolfo!!!";
			
			Console.WriteLine(result);
			
			
			Console.Write("Press any key to continue . . . ");
			
			Console.ReadKey(true);
		}
	}
}