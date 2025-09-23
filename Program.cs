/* What Day is it? Program
    Created by: Owen Douglas
    Asks the user for the day and delivers a message based on the day
*/

//Ask user for the day and lists the options
Console.WriteLine("What day is it?");
Console.WriteLine("1) Monday");
Console.WriteLine("2) Tuesday");
Console.WriteLine("3) Wednesday");
Console.WriteLine("4) Thursday");
Console.WriteLine("5) Friday");
Console.WriteLine("6) Saturday");
Console.WriteLine("7) Sunday");

//Blank line 
Console.WriteLine();

//Creates a empty string var for the message
string message;

//Creates day as the var for each message
string day = Console.ReadLine();

//starts the switch with day as the cases
switch (day)
{
    case "1":
        message = "Aack! I hate Mondays!";
        break;
    case "2":
        message = "It's Tuesday!";
        break;
    case "3":
        message = "Hump Day!";
        break;
    case "4":
        message = "It's Thursday!";
        break;
    case "5":
        message = "TGIF!";
        break;
    case "6":
        message = "It's the weekend!";
        break;
    case "7":
        message = "It's the weekend!";
        break;
    default:
        message = "That's not a day you silly goose!";
        break;
}

//Blank line for spacing
Console.WriteLine();

Console.WriteLine(message);
