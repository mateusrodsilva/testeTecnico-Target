using System.Text.Json;
using TesteFaturamentoDistribuidora.ViewModels;

var jsonDados = File.ReadAllText("../../../Dados/dados.json");

var dados = JsonSerializer.Deserialize<List<DadosFaturamentoDiarioViewModel>>(jsonDados);

var faturamentos = new List<double>();
foreach (var item in dados)
{
    if (item.valor > 0.0)
    {
        faturamentos.Add(item.valor);
    }
    else
    {
        continue;
    }
}

//Calcula O menor valor de faturamento ocorrido em um dia do mês;
var menorFaturamento = dados.FirstOrDefault(x => x.valor == faturamentos.Min());
Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês foi: R${menorFaturamento.valor.ToString("F2")}");

Console.WriteLine("----------------------------------------------------------------------------------------");
//O maior valor de faturamento ocorrido em um dia do mês;
var maiorFaturamento = dados.FirstOrDefault(x => x.valor == faturamentos.Max());
Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês foi: R${maiorFaturamento.valor.ToString("F2")}");

Console.WriteLine("----------------------------------------------------------------------------------------");
//Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
var mediaMensal = faturamentos.Any() == true ? CalculaMediaMensal(faturamentos) : 0.0; 
var diasFaturamentoMaiorQueMensal = dados.Where(x => x.valor > mediaMensal).Select(x => x.dia).ToList();
Console.WriteLine($"A média de faturamento foi R${mediaMensal.ToString("F2")}");

Console.WriteLine($"Os dias em que os faturamentos diários foram superiores a média mensal foram: {diasFaturamentoMaiorQueMensal.Count()} dias\n");

foreach (var dia in diasFaturamentoMaiorQueMensal)
{
    Console.WriteLine($"Dia {dia}");
}

double CalculaMediaMensal(List<double> faturamentos)
{
    var numElementos = faturamentos.Where(x => x > 0).ToList(); //Excluindo dias sem faturamento

    var divisor = numElementos.Count();

    var somaValores = numElementos.Sum(x => x);

    var media = somaValores / divisor;
    return media;
}
