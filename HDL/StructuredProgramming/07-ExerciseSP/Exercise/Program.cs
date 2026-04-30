int limit = 10;
var juices = new string[limit];
int iJuices = 0;
int op = 0;

do
{
    Console.Clear();
    ShowMenu();
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            if (iJuices < limit)
            {
                Console.Clear();
                Console.WriteLine("Enter the name of the juice:");
                var juice = Console.ReadLine();
                juices[iJuices] = juice;
                iJuices++;
            }
            else
            {
                Console.WriteLine("Juice limit reached. Cannot add more juices.");
            }
            break;
        case 2:

            ShowJuices(juices, iJuices);
            break;
            
        case 3:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option. Try again.");    
            break;
    }


} while (op != 3);

void ShowMenu()
{
    Console.WriteLine("1 - Add juice");
    Console.WriteLine("2 - Show juices");
    Console.WriteLine("3 - Exit");
}

void ShowJuices(string[] juices, int iJuices)
{
    Console.Clear();
    Console.WriteLine("====== Juices ======");
    for (int i=0; i<=iJuices; i++)
    {
        Console.WriteLine(juices[i]);
    }
    Console.WriteLine("====================");
    Console.WriteLine("Press any key to return to the menu...");
    Console.ReadKey();
}