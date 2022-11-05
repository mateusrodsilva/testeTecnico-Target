Console.Write("Digite um número: ");
var numero = int.Parse(Console.ReadLine());
var sequenciaFibonacci = Fibonacci(numero);
foreach (var item in sequenciaFibonacci)
{
    Console.WriteLine(item);
}

if (sequenciaFibonacci.Contains(numero)) //Verifica se o número digitado esta presente na sequência
{
    Console.WriteLine($"O número {numero} está presente na sequência");
}
else
{
    Console.WriteLine($"O número {numero} não está presente na sequência");
}

int[] Fibonacci(int number) //Constrói a sequência de Fibonacci
{
    int[] a = new int[number];
    a[0] = 0;
    a[1] = 1;
    for (int i = 2; i < number; i++)
    {
        a[i] = a[i - 2] + a[i - 1];
    }
    return a;
}