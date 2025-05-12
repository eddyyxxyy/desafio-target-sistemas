using Questao03.Services;

var dataDirectory = Path.Combine(AppContext.BaseDirectory, "Data");
var jsonPath = Path.Combine(dataDirectory, "faturamento.json");

await BillingService.ProcessarFaturamentoAsync(jsonPath);
