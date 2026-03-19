using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //verificar si es positivo
        //negativo

        //entrada
        Console.WriteLine("===Numero positivos y negativos===");
        int num;
        Console.WriteLine("dame un numero entero; ");
        num = Convert.ToInt32(Console.ReadLine()); ;

        //procesos
        //salida
        if (num == 0)
        {
            Console.WriteLine("es un numero positivo: ");

        }
        else
        {
            Console.WriteLine("es un numero negativo");

        }
    }
}