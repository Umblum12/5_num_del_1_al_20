int[] arr = new int[5];
int var = 0;
int suma = 0;
Console.WriteLine("Introduce 5 números entre 1 y 20");
int k = 0;
while (k < 5)
{
    do
    {
        Console.WriteLine("Introduce un número: ");
        var = int.Parse(Console.ReadLine());
        if (var < 1 || var > 20)
        {
            Console.WriteLine("Número fuera del rango. Introduce otro número");
        }
    } while (var < 1 || var > 20);
    arr[k] = var;
    suma += arr[k];
    k++;
}
Console.WriteLine("La suma es:" + suma);
Console.ReadKey(true);