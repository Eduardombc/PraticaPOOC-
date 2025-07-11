class Banda 
{
    private List<Album> albuns = new List<Album>();
    
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Album: {album.NomeDoAlbum} da Banda: {Nome}");
        }
    }
}