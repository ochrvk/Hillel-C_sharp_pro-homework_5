using Task_3;

while (true)
{
    Console.WriteLine("Choose your option: ");
    Console.WriteLine("1. Test shop");
    Console.WriteLine("2. Test Piece");
    Console.WriteLine("3. Exit");
    Console.Write(">>");

    string key = Console.ReadLine();

    switch (key)
    {
        case "1":
            StartShop();
            break;
        case "2":
            StartPiece();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Wrong type!");
            break;
    }
}

void StartPiece()
{
    using (var piece = new Piece())
    while (true)
    {

        Console.WriteLine("---Chose your option---");
        Console.WriteLine("1. Enter genre");
        Console.WriteLine("2. Enter author");
        Console.WriteLine("3. Enter title");
        Console.WriteLine("4. Enter year");
        Console.WriteLine("5. Show info");
        Console.WriteLine("6. Exit");
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
            case "6":
                return;
            default:
                Console.Write("Wrong type!");
                break;
        }
    }
}

void StartShop()
{
    using (var myShop = new Shop())
    {

        while (true)
        {
            Console.WriteLine("---Chose your option---");
            Console.WriteLine("1. Enter name ");
            Console.WriteLine("2. Enter address ");
            Console.WriteLine("3. Enter shop type ");
            Console.WriteLine("4. Show info");
            Console.WriteLine("5. Shop status");
            Console.WriteLine("6. Exit");
            Console.Write(">>");
            string key = Console.ReadLine();


            switch (key)
            {
                case "1":
                    Console.Write("Enter name here: ");
                    myShop.Name = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter address here: ");
                    myShop.Address = Console.ReadLine();
                    break;
                case "3":
                    InputType(myShop);
                    break;
                case "4":
                    Console.WriteLine(myShop.ToString());
                    break;
                case "5":
                    Console.WriteLine("Should the store be opened or closed?");
                    bool isOpened = BoolInput();
                    if (isOpened)
                    {
                        myShop.Open();
                    }
                    else
                    {
                        myShop.Close();
                    }
                    break;
                case "6":
                    return;
                default:
                    Console.Write("Wrong type!");
                    break;
            }
        }
    }

}

void InputType(Shop shop)
{
    Console.Write("Enter shop type here: ");
    while (true)
    {
        string shopType = Console.ReadLine();
        switch (shopType)
        {
            case "Grocery":
                shop.Type = Task_2.ShopType.Grocery;
                return;
            case "Household":
                shop.Type = Task_2.ShopType.Household;
                return;
            case "Clothing":
                shop.Type = Task_2.ShopType.Clothing;
                return;
            case "Footwear":
                shop.Type = Task_2.ShopType.Footwear;
                return;
            default:
                Console.Write("Wrong type. Please try again: ");
                break;
        }
    }
}

bool BoolInput()
{
    bool result;
    while (true)
    {
        try
        {
            result = bool.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.Write("Wrong type! Please try again: ");
        }
    }

    return result;
}