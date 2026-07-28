

// We use // to create a comment on c#
// console.Write("Luis") -> imprime luis
Console.WriteLine("Hello, World!");

/*
La opción de /* --- * /
nos permite comentar varias lineas de codigo dentro del cierre
*/

// Declarar variables -> sintaxis (TipoDato NombreVariable = Valor)
string name = "Luis";
Console.WriteLine("My name is: " + name + " and I'm using a varible to print my name:)");

// Declarar constantes ->> sintaxis [Const TipoDato Nombre = valor)
const int YearBorn = 2002;
Console.WriteLine("My year is : " + YearBorn + " and I'm using a cosnt to print my year:)");

/*
Variables: Su valor puede cambiar durante la ejecución del programa. 
Constantes: Su valor es inmutable después de la inicialización, lo que garantiza que no puedan ser modificadas accidentalmente. 
*/

//Metodos de print Usando $, puedes insertar variables directamente en la cadena.

Console.WriteLine($"Hello, my name is {name} and I was born in {YearBorn}."); 

// Formato compuesto (String.Format)

Console.WriteLine("Helo my name is {0} and I was born in {1}",name, YearBorn); 

