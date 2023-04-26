using POOS2.Models;

bool salirCiclo = false;

do
{
    Console.WriteLine("Ingrese el Nombre del Empleado");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el Salario del Empleado");
    double salario = double.Parse (Console.ReadLine());

    Console.WriteLine("Ingrese el Puesto del Empleado");
    string puesto = Console.ReadLine();

    DateTime tmp = new DateTime( 2023, 1, 30 );

    Empleado x = new Empleado(nombre, salario, puesto, tmp);

    Console.WriteLine($"El ISR del Empleado {x.getNombre()} es de {x.getISR()} mas la aportacion del seguro {x.aportacionIHHS()}");


    Console.WriteLine("Quiere Salir del Programa (Y/N)");
    char salir = char.Parse (Console.ReadLine());

    if (salir == 'Y')
    {

        salirCiclo = true;

    }


} while (salirCiclo == false);