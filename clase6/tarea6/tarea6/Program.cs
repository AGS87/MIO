//  SE GENERA NUMERO ALEATORIO
int NumSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

var n = 0; //Declaro contador

var rep = true; //Declaro booleano para condicion del ciclo WHILE

while (rep)
{

    Console.Clear();

    //  INGRESO DE NUMERO ELEGIDO
    Console.WriteLine("Ingrese el número para adivinar: ");
    var ingresado = int.Parse(Console.ReadLine().ToUpper());
    
    //  CONTADOR
    n++;


    if (ingresado > NumSecreto)     // PREGUNTO SI ES MAYOR EL NUMERO INGRESADO
    {
        Console.WriteLine("El numero elegido es muy grande, inténtalo nuevamente...");
    }

    else if (ingresado < NumSecreto)    // PREGUNTO SI ES MENOR EL NUMERO INGRESADO
    {
        Console.WriteLine("El numero elegido es muy pequeño, inténtalo nuevamente...");
    }

    else    // SE EJECUTA BLOQUE SI INGRESADO Y ALEATORIO SON IGUALES
    {
        Console.WriteLine($"¡Felicitaciones, has adivinado el numero secreto que era {NumSecreto}");
        Console.WriteLine($"¡¡Lo has logrado en {n} intentos!!");
        rep = false;    //  BOOLEANO FALSO PARA SALIR AL HALLAR EL NUMERO ALEATORIO
    }

    Console.ReadKey();
}