var age = 12;

if(age > 60)
{
    Console.WriteLine("Es de la tercera edad");
}
else if(age >18)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("Es menor de edad");
}

switch (age)
{
    case < 18:
        Console.WriteLine("Es menor de edad");
        break;
    case < 60:
        Console.WriteLine("Es mayor de edad");
        break;
    default:
        Console.WriteLine("Es de la tercera edad");
        break;
}