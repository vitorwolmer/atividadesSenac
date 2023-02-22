// See https://aka.ms/new-console-template for more information
Console.WriteLine(">>>Custo com garçons em evento de hotel<<<");

string nomeEvento;
int qtd, horas;
double custo;

Console.WriteLine("Digite o nome do evento:");
nomeEvento = Console.ReadLine();
Console.WriteLine("Digite a quantidade garçons:");
qtd = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas do evento:");
horas = Convert.ToInt32(Console.ReadLine());

custo = Convert.ToDouble(qtd * horas * 10.55);

Math.Round(custo, 2, MidpointRounding.ToEven);

Console.WriteLine("O custo total com garçons para o evento " + nomeEvento + " é de R$" + custo + ".");
