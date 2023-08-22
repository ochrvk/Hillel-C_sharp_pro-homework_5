// See https://aka.ms/new-console-template for more information

using Task_1;

Console.WriteLine("Hello, World!");
Start();

Console.WriteLine(GC.GetTotalMemory(false));
GC.Collect();
GC.WaitForPendingFinalizers();
Console.WriteLine(GC.GetTotalMemory(false));

Console.ReadLine();


void Start()
{
    Piece piece = new Piece();
    while (true)
    {

        Console.WriteLine("---Chose your option---");
        Console.WriteLine("1. Enter genre");
        Console.WriteLine("2. Enter author");
        Console.WriteLine("3. Enter title");
        Console.WriteLine("4. Enter year");
        Console.WriteLine("5. Show info");
        Console.WriteLine("Exit");
        Console.Write(">>");
        string key = Console.ReadLine();


        switch (key)
        {
            case "1":
                Console.Write("Enter genre here: ");
                piece.Genre = Console.ReadLine();
                break;
            case "2":
                Console.Write("Enter author here: ");
                piece.Author = Console.ReadLine();
                break;
            case "3":
                Console.Write("Enter title here: ");
                piece.Title = Console.ReadLine();
                break;
            case "4":
                Console.Write("Enter year here: ");
                while (true)
                {
                    try
                    {
                        piece.Year = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Write("Wrong type! Please try again: ");
                    }
                }
                break;
            case "5":
                Console.Write(piece.ToString());
                break;
            case "exit":
                return;
            default:
                Console.Write("Wrong type!");
                break;
        }
    }
}