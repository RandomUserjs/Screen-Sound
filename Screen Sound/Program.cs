Banda queen = new("Queen");

Album albumDoQueen = new("A night at the opera");

Musica musica1 = new(queen, "Love of my life")
{
	Duracao = 213,
	Disponivel = true,
};

Musica musica2 = new(queen, "Bohemian Rhapsody")
{
	Duracao = 354,
	Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Console.WriteLine(musica1.DescricaoResumida);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
