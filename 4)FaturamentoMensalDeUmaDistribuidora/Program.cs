// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

//SP – R$67.836,43
//RJ – R$36.678,66
//MG – R$29.229,88
//ES – R$27.165,48
//Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada 
//estado teve dentro do valor total mensal da distribuidora.


decimal sp = 67836.43M;
decimal rj = 366778.66M;
decimal mg = 29229.88M;
decimal es = 27165.48M;
decimal outros = 19849.53M;

decimal soma = sp + rj + mg + es + outros;

decimal porcentagemSp = (sp * 100) / soma;
Console.WriteLine($"O percentual de representação que o estado de SP teve foi de {porcentagemSp} %");

decimal porcentagemRj = (rj * 100) / soma;
Console.WriteLine($"O percentual de representação que o estado de RJ teve foi de {porcentagemRj} %");

decimal porcentagemMg = (mg * 100) / soma;
Console.WriteLine($"O percentual de representação que o estado de MG teve foi de {porcentagemMg} %");

decimal porcentagemEs = (es * 100) / soma;
Console.WriteLine($"O percentual de representação que o estado de ES teve foi de {porcentagemEs} %");

decimal porcentagemOutros = (outros * 100) / soma;
Console.WriteLine($"O percentual de representação de OUTROS estados foi de {porcentagemOutros} %");