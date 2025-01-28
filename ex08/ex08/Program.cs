/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ex08
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double preco;
			int desconto;
			double precoFinal;
			
			Console.Write("Preço do produto: R$");
			
			preco = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Desconto (%): ");
			
			desconto = Convert.ToInt32(Console.ReadLine());
			
			precoFinal = preco - (preco*desconto/100);
			
			Console.WriteLine("O preço com desconto é: R$"+ precoFinal);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}