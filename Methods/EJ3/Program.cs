// Write a method that counts how many times given number appears in given array.

static int NumerodeRepeticiones(int[] array, int numbuscado)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == numbuscado)
            count ++;

    return count;

}

Console.WriteLine("Dime el tamaño del array: ");
int arraysize = int.Parse(Console.ReadLine());

int[] array = new int[arraysize];
Console.WriteLine("Introduce los números del array: ");
<<<<<<< HEAD

=======
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

Console.Write("Número buscado: ");
        int numbuscado = int.Parse(Console.ReadLine());

        Console.WriteLine("El numero {0} aparece {1} veces en el array", numbuscado,
            NumerodeRepeticiones(array, numbuscado));
>>>>>>> 70f31d3ee8035177a11d0e67445787edf67b0789
