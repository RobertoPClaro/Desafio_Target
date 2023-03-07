//5) Escreva um programa que inverta os caracteres de um string.
//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;


Console.WriteLine("Digite o texto que sera invertido: ");

string novaStr = string.Empty;
string strOriginal = Console.ReadLine();

for (int indice = strOriginal.Length - 1; indice >= 0; indice--)
{
    novaStr += strOriginal[indice];
}
Console.WriteLine("---------------------------------------------#---------------------------------------------");
Console.WriteLine("Texto invertido: ");
Console.WriteLine(novaStr);
Console.ReadKey();