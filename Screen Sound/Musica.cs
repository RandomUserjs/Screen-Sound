class Musica
{
	public string Nome { get; set; }

	public string Artista { get; set; }

	public int Duracao { get; set; }

	public bool Disponivel { get; set; }

	public string DescricaoResumida =>
		$"A música {Nome} pertence à banda {Artista}";

	public void ExibirFichaTecnica()
	{
		Console.WriteLine($"Nome: {Nome}");
		Console.WriteLine($"Artista: {Artista}");
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
