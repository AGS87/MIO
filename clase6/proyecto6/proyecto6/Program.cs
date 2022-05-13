/*  CLASE N°6   */

/*
var numero1 = 1; 

// HAY QUE INICIALIZARLA SI O SI
//      variable tipo implicito --- si pongo var el compilador va a inferir el tipo de variable

int numero2 = 4;    // variable tipo explícito


int num1, num2, num3; 

var num1, num2, num3;  ------esto no va

*/

/*
var miVariable = 0;

Console.WriteLine(&"El contenido de mi variable es: {miVariable}");

var miVariable2 = "un texto";

Console.WriteLine(&"El contenido de mi variable es: {miVariable2}");
*/

var respuesta = "";

do
{
    Console.Clear();
    Console.WriteLine("Ingrese nombre:");
    var usuario = Console.ReadLine();

    Console.WriteLine($"¡Hola {usuario}!");

    Console.WriteLine($"¿Desea continuar: (S/N)?");
    respuesta = Console.ReadLine();

    if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
    else if (respuesta.ToUpper() != "S")
    {
        Console.WriteLine("Opcion no valida.");
    }

}
while (respuesta.ToUpper() == "S");


