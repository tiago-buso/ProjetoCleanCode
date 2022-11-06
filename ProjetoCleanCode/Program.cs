using ProjetoCleanCode.CPF;

Console.WriteLine("Digite o CPF para ser validado, com pontos e traço");
string cpf = Console.ReadLine();

CPF_Old cpf_old = new CPF_Old();
bool cpfValido = cpf_old.ValidarCPF(cpf);

string textoValido = cpfValido ? "Válido" : "Inválido";

Console.WriteLine($"O CPF é: {textoValido}");