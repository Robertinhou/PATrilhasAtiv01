/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex02
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num;
			Console.WriteLine("Digite um número:");
			num = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("O número é: "+ num);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}