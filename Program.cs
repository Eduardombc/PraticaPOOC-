Banda Queen = new Banda("Queen");

Banda JonhLennon = new Banda("John Lennon");

Musica musica1 = new Musica (Queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Genero = "Rock",
    Disponivel = false
};

Musica musica2 = new Musica (JonhLennon,"Imagine")
{
    Genero = "Pop",
    Duracao = 183,
    Disponivel = true
};

Musica musica3 = new Musica (Queen, "Don't Stop Me Now")
{
    Duracao = 210,
    Genero = "Rock",
    Disponivel = true
};

Console.Clear();

Album albumDoQueen = new Album("A Night at the Opera");
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica3);
albumDoQueen.ExibirAlbum();

Queen.AdicionarAlbum(albumDoQueen);
Queen.ExibirDiscografia();


Console.WriteLine("\n=========================================");
Console.WriteLine("Fim da Logica de Exibição da Discografia");
Console.WriteLine("========================================= \n");


Episodio episodio1 = new Episodio(1, "Introdução ao Podcast", 30);
episodio1.AdicionarConvidado("João Silva");
episodio1.AdicionarConvidado("Maria Souza");


Episodio episodio2 = new Episodio(2, "Entrevista com Especialista", 45);
episodio2.AdicionarConvidado("Dr. Ana Costa");


Podcast podcast = new Podcast("Aprendendo C#", "Eduardo Cavalcante");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();


