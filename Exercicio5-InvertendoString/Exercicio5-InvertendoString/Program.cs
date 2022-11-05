Console.WriteLine("### Programa de inversão de textos ###");
Console.WriteLine("Escreva um texto:");
var texto = Console.ReadLine();

Console.WriteLine("----------------------");
Console.WriteLine("Texto Invertido:");
Console.WriteLine(new String((new Stack<char>(texto)).ToArray())); //Instanciando classe Stack aplicado o conceito de Pilha (LIFO - Last In, First Out), assim o último caractere será o primeiro na nova string
