/* Ejemplo de condicional IF 
   <<<<<<<<<<<<<<<<<<<<<<<<<*/

/*
// Le pedimos al usuario que ingrese su edad
Console.Write("Ingrese su edad: ");

// obtenemos la edad por teclado
int edad = int.Parse(Console.ReadLine());

// obtenemos equipo de futbol por teclado
int equipo = int.Parse(Console.ReadLine());

Console.WriteLine("Su edad es: " + edad);
Console.ReadKey();

/*
 bool condicion = edad < 18 && equipo == "River";

if (condicion)
{
}
*/

/*
if (edad < 18 && equipo == "River")   //Evaluamos la condicion
{   
    //Instrucciones si se cumple la condicion
    Console.WriteLine("Usted es menor de edad");
}
else
{   
    //instrucciones si la condicion no se cumple
    Console.WriteLine("Usted es mayor de edad");
}
*/

/* si es una sola linea de codigo en el bloque
if podemos no usar las llaves */




//---------------------------------------------------------------------------//




/*Ejemplo de IF-ELSEIF-ELSE 
  <<<<<<<<<<<<<<<<<<<<<<<<<*/ 


/*
Console.Write("Ingrese su edad: ");

// obtenemos la edad por teclado
int edad = int.Parse(Console.ReadLine());

if (edad < 0 || edad > 110)
{
    Console.WriteLine("Edad no valida");
}
else if (edad < 12)
{
    Console.WriteLine("Va a la Primaria"); 
}
else if (edad < 18)
{
    Console.WriteLine("Va a la Secundaria");
}
else if (edad < 28)
{
    Console.WriteLine("Va a la facultad");
}
else
{
    Console.WriteLine("A trabajar no queda otra");
}
*/



//-------------------------------------------------------------------------//



/*   Ejemplo de SWITCH      
     =================    */


Console.WriteLine("1- Suma");
Console.WriteLine("2- Resta");
Console.WriteLine("3- Multiplicacion");
Console.WriteLine("4- Division");

Console.WriteLine("Ingrese la operación");
string operacion = Console.ReadLine();

Console.WriteLine("Ingrese primer numero");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0; // declaro resultado sin inicializar

switch (operacion)
{
    case "1":
        resultado = num1 + num2;
        Console.WriteLine("suma > " + resultado);
        break;

    case "2":
        resultado = num1 - num2;
        Console.WriteLine("resta > " + resultado);
        break;

    case "3":
        resultado = num1 * num2;
        Console.WriteLine("producto > " + resultado);
        break;

    case "4" when num2 != 0:
        resultado = num1 / num2;
        Console.WriteLine("division > " + resultado);
        break;

    default:
        Console.WriteLine("Ingreso una opcion no valida");
        break ;
}