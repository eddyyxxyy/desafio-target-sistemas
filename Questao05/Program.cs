Console.WriteLine("Digite a string para ser invertida:");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input)) {
    Console.WriteLine("A string é vázia ou inválida!");
    Environment.Exit(exitCode: 1);
}

string resultado = InvertString(input);

Console.WriteLine($"String invertida: {resultado}");
