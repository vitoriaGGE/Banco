using Banco;
using System.Globalization;

ContaBancaria conta;

Console.Write("Informe aqui a sua conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Informe aqui o titular da conta: ");
string titular  = Console.ReadLine();

Console.WriteLine("Haverá depósito inicial?");
string resp = Console.ReadLine();

if (resp == "Sim" ||  resp == "sim") {
    Console.Write("Entre com o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
} else {
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
conta.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados:");    
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);