﻿class Musica
{
	public Musica(Banda artista, string nome)
	{
		Artista = artista;
		Nome = nome;
	}

	public string Nome { get; set; }

	public Banda Artista { get; }

	public int Duracao { get; set; }

	public bool Disponivel { get; set; }

	public string DescricaoResumida =>
		$"A música {Nome} pertence à banda {Artista.Nome}";

	public void ExibirFichaTecnica()
	{
		Console.WriteLine($"\nNome: {Nome}");
		Console.WriteLine($"Artista: {Artista.Nome}");
		Console.WriteLine($"Duração: {Duracao}s");
		if (Disponivel)
		{
			Console.WriteLine("A música está dísponivel no seu plano");
		}
		else
		{
			Console.WriteLine("Esta música não está dísponivel no seu plano. Adquira o plano Plus+ agora!");
		}
	}
}
