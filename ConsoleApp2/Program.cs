Console.Write("Ingrese su edad: ");
int edad;
if (int.TryParse(Console.ReadLine(), out edad))
{
    Console.WriteLine("Edad válida: " + edad);
}
else
{
    Console.WriteLine("Error: no es un número entero");
}
