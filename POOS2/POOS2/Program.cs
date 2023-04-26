using POOS2.Models;

bool salirCiclo = false;

do
{
    Console.WriteLine("Ingrese el Nombre del Empleado");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el Salario del Empleado");
    double salario = double.Parse (Console.ReadLine());

    Empleado x = new Empleado(nombre, salario);

    Console.WriteLine($"El ISR del Empleado {x.getNombre()} es de {x.getISR()}");


    Console.WriteLine("Quiere Salir del Programa (Y/N)");
    char salir = char.Parse (Console.ReadLine());

    if (salir == 'Y')
    {

        salirCiclo = true;

    }


} while (salirCiclo == false);