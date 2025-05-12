Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");

string? input = Console.ReadLine();

try
{
    if (string.IsNullOrWhiteSpace(input)) {
        throw new FormatException();
    }

    ulong num = ulong.Parse(input);

    if (IsFibonacciWithPerfectSquare(num))
    {
        Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine($"O número {num} NÃO pertence à sequência de Fibonacci.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, insira um número válido (maior ou igual a 0).");
}
catch (OverflowException)
{
    Console.WriteLine("Erro: O número é muito grande ou menor que zero para ser processado.");
}
catch (Exception ex) {
    Console.WriteLine($"Erro inesperado: {ex.Message}");
}
