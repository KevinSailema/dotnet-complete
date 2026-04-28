

int res3 = Area(5);

// Ejemplo de función con un parámetro y un valor de retorno
int Area(int s)
{
    int res = s * s;
    return res;
}
Console.WriteLine(res3);


// Ejemplo de función con parámetros y sin valor de retorno
void Show(string message)
{
    Console.WriteLine(message);
}
Show("Clean Architecture");

// Ejemplo de función sin parámetros y sin valor de retorno

void Bye()
{
    Console.WriteLine("Bye");
}
Bye();