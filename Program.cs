Livro l1 = new Livro();
l1.titulo = "clean code";
l1.autor = "Pablo Marçal";
l1.ano = 2004;
l1.paginas = 361;

l1.ExibirInformacoes();
bool v1 = l1.VerificarTrezentos();
Console.WriteLine($"Esse livro tem mais de trezentas páginas? {v1}");
