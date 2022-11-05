using Exercicio4_DistrubuidoraEstado;

var listaFaturamentosEstados = new List<FaturamentoMensal>();

listaFaturamentosEstados.Add(new FaturamentoMensal()
{
    Estado = EstadosEnum.SP,
    Faturamento = 67836.43
});
listaFaturamentosEstados.Add(new FaturamentoMensal()
{
    Estado = EstadosEnum.RJ,
    Faturamento = 36678.66
});
listaFaturamentosEstados.Add(new FaturamentoMensal()
{
    Estado = EstadosEnum.MG,
    Faturamento = 29229.88
});
listaFaturamentosEstados.Add(new FaturamentoMensal()
{
    Estado = EstadosEnum.ES,
    Faturamento = 27165.48
});
listaFaturamentosEstados.Add(new FaturamentoMensal()
{
    Estado = EstadosEnum.Outros,
    Faturamento = 19849.53
});

var faturamentos = new List<double>();

foreach (var item in listaFaturamentosEstados)
{
    faturamentos.Add(item.Faturamento);
}

var cemPorCento = faturamentos.Sum();

var faturamentoSp = listaFaturamentosEstados.FirstOrDefault(x => x.Estado == EstadosEnum.SP).Faturamento;
var spPorCento = (faturamentoSp * 100) / cemPorCento;

var faturamentoRj = listaFaturamentosEstados.FirstOrDefault(x => x.Estado == EstadosEnum.RJ).Faturamento;
var rjPorCento = (faturamentoRj * 100) / cemPorCento;

var faturamentoMg = listaFaturamentosEstados.FirstOrDefault(x => x.Estado == EstadosEnum.MG).Faturamento;
var mgPorCento = (faturamentoMg * 100) / cemPorCento;

var faturamentoEs = listaFaturamentosEstados.FirstOrDefault(x => x.Estado == EstadosEnum.ES).Faturamento;
var esPorCento = (faturamentoEs * 100) / cemPorCento;

var faturamentoOutros = listaFaturamentosEstados.FirstOrDefault(x => x.Estado == EstadosEnum.Outros).Faturamento;
var outrosPorCento = (faturamentoOutros * 100) / cemPorCento;


Console.WriteLine("O faturamento mensal da distribuidora, detalhando por estado foi: \n" +
    $"SP – R$67.836,43 - Representando {spPorCento.ToString("F2")}% do faturamento total;\n" +
    $"RJ – R$36.678,66 - Representando {rjPorCento.ToString("F2")}% do faturamento total;\n" +
    $"MG – R$29.229,88 - Representando {mgPorCento.ToString("F2")}% do faturamento total;\n" +
    $"ES – R$27.165,48 - Representando {esPorCento.ToString("F2")}% do faturamento total;\n" +
    $"Outros – R$19.849,53 - Representando {outrosPorCento.ToString("F2")}% do faturamento total;\n" +
    $"-------------------------------------------------------------------------------\n" +
    $"O faturamento total foi igual a R${cemPorCento.ToString("F2")}");