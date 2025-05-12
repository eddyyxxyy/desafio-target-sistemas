var stateBilling = new Dictionary<string, decimal>
    {
        { "SP", 67836.43m },
        { "RJ", 36678.66m },
        { "MG", 29229.88m },
        { "ES", 27165.48m },
        { "Outros", 19849.53m }
    };

decimal totalBilling = 0;
foreach (var billing in stateBilling.Values)
{
    totalBilling += billing;
}

Console.WriteLine("Percentual de representação dos estados no faturamento total:");
foreach (var state in stateBilling)
{
    decimal participation = (state.Value / totalBilling) * 100;
    Console.WriteLine($"{state.Key}: {participation:F2}%");
}
