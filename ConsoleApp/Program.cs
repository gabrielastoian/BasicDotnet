
Console.Title = "My Console App"; //for windows only

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;

//trying out some Console methods
Console.Write("What is your name? ");
var myName = Console.ReadLine();

//also returns the key we pressed
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

//if true it intercepts the pressed key 
Console.WriteLine("Press another key to continue...");
Console.ReadKey(true);

//Console.WriteLine($"{Console.Title}"); only works on Windows

//Console.Clear();

//Console.Beep(440, 1000); plays a sound at 440 Hz for 1 second; only works on Windows

Console.WriteLine("C:\\Users\\RB\\Desktop\\MyFile.txt"); //\\ is an escape character
//Console.WriteLine("C:\Users\RB\Desktop\MyFile.txt"); //this will throw an error because \U is an escape character

Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt"); //@ ignores the escape characters

var myFavoriteNumber = 23;
Console.WriteLine($"My favorite number is {myFavoriteNumber}.");// string interpolation
//Console.WriteLine("My favorite number is {myFavoriteNumber}."); //this will not work because it is not interpolated
//Console.WriteLine("My favorite number is " + myFavoriteNumber); //this will work but is not as clean as string interpolation
//Console.WriteLine("My favorite number is {0}.", myFavoriteNumber); //this will work but is not as clean as string interpolation

string name1 = Console.ReadLine();
string name2 = Console.ReadLine();
Console.WriteLine($"#1: {name1,20}"); //right align
Console.WriteLine($"#2: {name2,20}"); //right align

Console.WriteLine($"{name1,-20} - 1"); //left align
Console.WriteLine($"{name2,-20} - 2"); //left align

Console.WriteLine(Math.PI); //print pi
Console.WriteLine($"{Math.PI:0.000}"); //round to 3 decimal places

Console.WriteLine($"{42:#.##}"); // Displays "42"
Console.WriteLine($"{42.1234:#.##}"); // Displays "42.12"

float currentHealth = 4;
float maxHealth = 9;
Console.WriteLine($"{currentHealth/maxHealth:0.0%}"); // Displays "44.4%"