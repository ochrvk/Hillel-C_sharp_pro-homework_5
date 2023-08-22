using Task_2;


Start();


void Start()
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
                shop.Type = ShopType.Grocery;
                return;
            case "Household":
                shop.Type = ShopType.Household;
                return;
            case "Clothing":
                shop.Type = ShopType.Clothing;
                return;
            case "Footwear":
                shop.Type = ShopType.Footwear;
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