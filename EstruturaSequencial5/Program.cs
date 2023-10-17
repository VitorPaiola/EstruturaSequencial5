using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');
int cod1 = int.Parse(vet[0]);
int num1 = int.Parse(vet[1]);
double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

vet = Console.ReadLine().Split(' ');
int cod2 = int.Parse(vet[0]);
int num2 = int.Parse(vet[1]);
double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

double total = num1 * valor1 + num2 * valor2;

Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));