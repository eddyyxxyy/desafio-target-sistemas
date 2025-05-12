using System.Text.Json;
using Questao03.Models;

namespace Questao03.Services;

public class BillingService
{
    public static async Task ProcessarFaturamentoAsync(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        decimal lesser = decimal.MaxValue;
        decimal bigger = decimal.MinValue;
        decimal sum = 0;
        int daysWithBilling = 0;
        List<DailyBilling> faturamentos = new();

        await using FileStream fs = File.OpenRead(path);
        await foreach (
            var currentDayBilling in
            JsonSerializer
                .DeserializeAsyncEnumerable<DailyBilling>(fs, options))
        {
            if (currentDayBilling.Value <= 0) continue;

            faturamentos.Add(currentDayBilling);
            sum += currentDayBilling.Value;
            daysWithBilling++;

            if (currentDayBilling.Value < lesser) lesser =
                currentDayBilling.Value;

            if (currentDayBilling.Value > bigger) bigger =
                currentDayBilling.Value;
        }

        if (daysWithBilling == 0)
        {
            Console.WriteLine("Não há dados válidos para calcular.");
            return;
        }

        var average = sum / daysWithBilling;
        int daysAboveAverage = faturamentos.Count(f => f.Value > average);

        Console.WriteLine($"""
        Menor faturamento: R$ {lesser:C2}
        Maior faturamento: R$ {bigger:C2}
        Média: R$ {average:C2}
        Dias acima da média: {daysAboveAverage}
        """);
    }
}
