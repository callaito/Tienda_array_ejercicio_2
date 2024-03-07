// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] producto = new string[3];
double[] precio = new double[3];
double total = 0;
double promedio ;



for (int i = 0; i < producto.Length; i++)
{

    Console.WriteLine("Introduzca los productos: {0}"+(i+1));
    Console.WriteLine();
    producto[i] = Console.ReadLine();

    Console.WriteLine("Introduzca el precio: {0}"+(i+1));
    precio[i] = Convert.ToDouble(Console.ReadLine());


    total += precio[i];
}

for (int i = 0; i < producto.Length; i++)
{
    
    
}
promedio = total/precio.Length;
Console.WriteLine("El promedio es : "+ promedio);