/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex03
{
	class Program
	{
		public static void Main(string[] args)
		{
			float num;
			Console.WriteLine("Insira um número decimal: ");
			
			num = float.Parse(Console.ReadLine());
			
			Console.WriteLine("número decimal: "+ num);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}