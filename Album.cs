class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string NomeDoAlbum { get; set; }
    public string Genero { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nomeDoAlbum)
    {
        NomeDoAlbum = nomeDoAlbum;
    }
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirAlbum()
    {
        Console.Clear();
        Console.WriteLine($"Álbum: {NomeDoAlbum}");
        Console.WriteLine($"Duração Total: {DuracaoTotal} segundos");
        Console.WriteLine("Músicas:");
        for (int i = 0; i < musicas.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {musicas[i].Titulo}");
            Console.WriteLine($"Gênero: {musicas[i].Genero}\n");
        }
    }
}