// See https://aka.ms/new-console-template for more information



Console.WriteLine("Escribe el primer número: ");
int uno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe el segundo número: ");
int dos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El número mayor es: " + GetMax(uno, dos));


static int GetMax(int uno, int dos)
{
    return Math.Max(uno, dos);
}