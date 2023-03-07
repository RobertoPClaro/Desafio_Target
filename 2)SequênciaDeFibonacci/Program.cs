//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número,
//ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

Console.WriteLine("Informe um numero para saber se ele faz parte da sequência Fibonacci");
int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 1;
int aux = 0;

Console.WriteLine("-----------------------------------------#-----------------------------------------");
Console.WriteLine("Sequência de Fibonacci");
while (num2 <= numeroEscolhido)
{
    aux = num1;
    num1 = num2;
    num2 = num1 + aux;
    Console.WriteLine(num2);

    if (num2 == numeroEscolhido)
    {
        Console.WriteLine("-----------------------------------------#-----------------------------------------");
        Console.WriteLine($"Número {numeroEscolhido} pertence a sequência Fibonacci...");
        return;
    }
    if (num2 > numeroEscolhido)
    {
        Console.WriteLine("-----------------------------------------#-----------------------------------------");
        Console.WriteLine($"Número {numeroEscolhido} não pertence a sequência Fibonacci...");
    }
}
Console.ReadLine();
