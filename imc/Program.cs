using System;

namespace imc
{
	public class cidade
	{
		public int cep { get; set; }
		public string descricao { get; set; }
		public char uf { get; set; }

	}
	class Program
	{
	











		static void Main(string[] args)
		{
			Console.WriteLine("<==Calcula IMC==>");
			calcula();

		}
		static void calcula()
		{
			Console.WriteLine("Informe sua Altura em CM");
			double altura = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Informe seu Peso em KG");
			double Peso = Convert.ToDouble(Console.ReadLine());
			var altura2 = (altura * altura);
			double diferenca = (Peso / altura2);
			var resultado = diferenca.ToString().Substring(0, 2);
			Console.WriteLine($@"Seu IMC é {resultado}");
		}
	}
}
