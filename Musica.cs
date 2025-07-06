class Musica
{
    public Musica(Banda artista, string titulo)
    {
        Artista = artista;
        Titulo = titulo;
    }
    

    public string Titulo{ get; }
    public Banda Artista { get; }
    public int Duracao { get; set; } 
    public bool Disponivel { get; set; }
    public string NomeCompleto => $"{Artista.Nome} - {Titulo}";
    public string Genero { get; set; }

    public void ExibirMusica()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Necessário Upgrade de Plano para ouvir")}");
        Console.WriteLine($"Nome Completo: {NomeCompleto}");
    }

}