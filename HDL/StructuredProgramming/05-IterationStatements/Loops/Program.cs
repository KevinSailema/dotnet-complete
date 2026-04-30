// Conditional Statemets
// Repetir sentencias
var names = new string[3]
{
    "Hector", "Juan", "Pedro"
};


int i = 0;
// Por lo menos que se ejecute una vez Do-While
do
{
    Console.WriteLine(names[i]);
    i = i +1;
} while (i <names.Length);

// Mientras se cumpla la condición se ejecuta el bloque de código While
while (i < names.Length)
{
    Console.WriteLine(names[i]);
    i = i +1;
}

for (int j = 0; j < names.Length; j++)
{
    Console.WriteLine(names[j]);
}