class Livro
{
    public string titulo;
    public string autor;
    public int paginas;
    public int ano;
    public void  ExibirInformacoes()
    {
        Console.WriteLine($"Titulo: {titulo}, Autor: {autor}, Paginas: {paginas}");
    }

    public bool VerificarTrezentos()
    {
      return (paginas > 300);
    }
}



