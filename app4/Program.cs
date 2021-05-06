Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Digite o primeiro nome da pessoa para busca: ");
string primeiroNome = Console.ReadLine();

Pessoa pessoinha = app.BuscarPessoa(primeiroNome);
if (pessoinha != null) {
    Console.WriteLine("Pessoa Encontrada!!!");

    //Mudar o Nome
    string resposta1 = "";
    do {
        Console.Write("Deseja mudar o nome? (S/N) ");
        resposta1 = Console.ReadLine();
        if (resposta1 == "S") {
            do {
                Console.WriteLine();
                Console.Write("Digite o nome: ");
                pessoinha.NomeCompleto = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(pessoinha.NomeCompleto));
        }
    } while (resposta1 != "S" && resposta1 != "N");

    //Envelhecer
    Console.Write("Deseja envelhecer essa pessoa em um ano? (S/N) ");
    string resposta2 = Console.ReadLine();
    if (resposta2 == "S") {
        var data = DateTime.Parse(pessoinha.DataNascimento);
        data = data.AddYears(-1);
        pessoinha.DataNascimento = data.ToString("dd/MM/yyyy");
    }
}