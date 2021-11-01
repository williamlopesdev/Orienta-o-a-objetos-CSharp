using System;

namespace SegundoProjeto
{
	class Program
	{
		static void Main(string[] args)
		{
			var iesUTFPR = new Instituicao()
			{
				Nome = "UTFPR",
				Endereco = new Endereco()
				{
					Rua = "Brasil",
					Numero = "1000"
				}
			};
			var iesCC = new Instituicao()
			{
				Nome = "Casa	do	Código",
				Endereco = new Endereco()
				{
					Bairro = "Liberdade"
				}
			};

		}
	}
}