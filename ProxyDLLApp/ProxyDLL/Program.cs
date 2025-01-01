Console.WriteLine("Hello, World!");


string text = "";

switch (args.Length)
{
	case 1:
		text = "Not content provided";
		break;
	case 2:
        text = args[1];
		break;
	default:
        Console.WriteLine("Incorrect args provided");
		return;
}

File.WriteAllText(args[0], text);