public class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; set; }
    public int Duracao { get; set; } // Duração em minutos
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

}