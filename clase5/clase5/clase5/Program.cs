Console.WriteLine("Desea continuar? (S/N)")
var texto = Console.ReadLine();

if (texto.ToUpper() == "S")
{
    Console.WriteLine("Usted ingresó que SI");
}
else if (texto.ToLower() == "n")
{ 
    Console.WriteLine("Usted ingresó que NO");
}
else
{
    Console.WriteLine("Usted no entendió nada");
}