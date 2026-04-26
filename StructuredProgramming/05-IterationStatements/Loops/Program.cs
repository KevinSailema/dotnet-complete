// Conditional Statemets
// Repetir sentencias
var names = new string[3]
{
    "Hector", "Juan", "Pedro"
};


int i = 0;
do
{
    Console.WriteLine(names[i]);
    i = i +1;
} while (i <names.Length);
