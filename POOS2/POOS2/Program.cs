using POOS2.Models;

bool salirCiclo = false;

// tipoDato nmVariable =  asignacion;


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


salirCiclo = false;

do {

    Console.WriteLine("Ingrese el radio del Circulo");
    double r = double.Parse(Console.ReadLine());
    Circulo c = new Circulo(r);
    Console.WriteLine(c.ToString() );

    Console.WriteLine("Quiere Salir del Programa (Y/N)");
    char salir = char.Parse(Console.ReadLine());

    if (salir == 'Y')
    {

        salirCiclo = true;

    }

} while (salirCiclo == false);


salirCiclo = false;

do
{
    Console.WriteLine("Ingrese el Lado 1");
    double l1 = double.Parse(Console.ReadLine());


    Console.WriteLine("Ingrese el Lado 2");
    double l2 = double.Parse(Console.ReadLine());

    Cuadrado c1 = new Cuadrado(l1, l2);

    Console.WriteLine(c1.ToString());

    Console.WriteLine("Quiere Salir del Programa (Y/N)");
    char salir = char.Parse(Console.ReadLine());

    if (salir == 'Y')
    {

        salirCiclo = true;

    }

} while (salirCiclo == false);