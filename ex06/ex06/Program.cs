/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex06
{
	class Program
	{
		public static void Main(string[] args)
		{
			decimal num;
			Console.WriteLine("digite um número: ");
			
			num = Convert.ToDecimal(Console.ReadLine());
			
			Console.WriteLine(num);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}