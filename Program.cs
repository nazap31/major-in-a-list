Console.WriteLine("Mayor en una lista!");

Console.Write("Ingrese el tamaño de la lista: ");
int[] numbers = new int[Int32.Parse(Console.ReadLine() ??"0")];

// Llenamos el array
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Ingrese un numero: ");
    string input = Console.ReadLine () ?? "0";
    numbers[i] = Int32.Parse(input);
}
//Buscar el numero mayor en la lista de numeros ingresados por el usuario
int mayor = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (mayor > numbers [i])
    {
        
    }
    else
    {
        mayor = numbers[i];
    }
}

//Se imprime el numero mayor
Console.Write("El numero mayor es : " + mayor);
