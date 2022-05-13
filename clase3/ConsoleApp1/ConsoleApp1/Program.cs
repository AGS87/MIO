
//Borrar pantalla
Console.Clear();

//Pedimos al usuario que ingrese su nombre
Console.WriteLine("Escriba su NOMBRE");

//Leemos el nombre del usuario
string nombre;
nombre = Console.ReadLine();//string nombre = Console.ReadLine();

//Pedimos el apellido
Console.WriteLine("Escriba su APELLIDO");

string apellido;
apellido = Console.ReadLine();


//Mostramos el nombre

Console.WriteLine("HOLA " + nombre + " " + apellido + ", este es mi segundo programa");
Console.ReadKey();
//  O
//  Console.Write("HOLA " + nombre + " " + apellido);
//  Console.WriteLine(", este es mi segundo programa");

Console.Clear();

Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

//Para mostrar mensaje y presionar tecla para finalizar
//Console.WriteLine("Presione una tecla para finalizar");

bool MayorDeEdad = edad > 18;

if (MayorDeEdad)
{
    Console.Clear();
    Console.Beep();
    Console.WriteLine("USTED ES MAYOR DE EDAD");
    Console.ReadKey();

}
else {
    Console.Clear();
    Console.Beep();
    Console.WriteLine("USTED ES MENOR DE EDAD");
    Console.ReadKey();

}

float num;

for () { 

}



