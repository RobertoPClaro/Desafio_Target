//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar,
//que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.



using Desafio_TargetSistemas;
using Newtonsoft.Json;

decimal menorValor = decimal.MaxValue;
decimal maiorValor = decimal.MinValue;
decimal soma = 0;
decimal media = 0;

int diasFaturamentoMaiorQuemedia = 0;
int diasValidos = 0;

List<Venda> dias = null;

using (StreamReader stream = new StreamReader(@"C:\Users\rober\OneDrive\Área de Trabalho\DesafioTargetSistemas\Desafio_Target\3)FaturamentoDiarioDeUmaDistribuidora\dados.json")) // Caminho do arquivo Json
{
    string jsonString = stream.ReadToEnd();
    dias = JsonConvert.DeserializeObject<List<Venda>>(jsonString);
}

foreach (var dia in dias)
{
    if (dia.Valor > 0)
    {
        if (dia.Valor > maiorValor)
        {
            maiorValor = dia.Valor;
        }
        if (dia.Valor < menorValor)
        {
            menorValor = dia.Valor;
        }
        soma += dia.Valor;
        diasValidos++;
    }

}

media = soma / diasValidos;

foreach (var dia in dias)
{
    if (dia.Valor > media)
    {
        diasFaturamentoMaiorQuemedia++;
    }
}

Console.WriteLine($"Quantidadde de dias que o faturamento foi maior que a media diario = {diasFaturamentoMaiorQuemedia}");
Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês foi = {menorValor.ToString("F4")}");
Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês foi = {maiorValor.ToString("F4")}");