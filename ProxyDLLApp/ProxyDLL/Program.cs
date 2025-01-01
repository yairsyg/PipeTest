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

Console.WriteLine($"Writing the content \"{args[1]}\" to the path \"{args[0]}\"");

File.WriteAllText(args[0], text);