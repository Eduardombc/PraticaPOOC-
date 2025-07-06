class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalDeEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        
        Console.WriteLine($"Podcast: {Nome} - Apresentado por: {Host}\n");
        for (int i = 0; i < TotalDeEpisodios; i++)
        {
            Console.WriteLine($"Episódio {i + 1}: {episodios[i].Titulo}");
            Console.WriteLine($"Resumo: {episodios[i].Resumo} \n");
        }
        Console.WriteLine($"Esse Podcast possui um total de episódios: {TotalDeEpisodios}");
    }

}