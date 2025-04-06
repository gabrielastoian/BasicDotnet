// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, what's your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "! How old are you?");
string age = Console.ReadLine();
Console.WriteLine("Nice to meet you, " + name + "! You are " + age + " years old.");
Console.WriteLine("What is your favorite color?");
string color = Console.ReadLine();
Console.WriteLine("Your favorite color is " + color + ". That's great!");
Console.WriteLine("What is your favorite hobby?");
string hobby = Console.ReadLine();
Console.WriteLine("Your favorite hobby is " + hobby + ". That's awesome!");
Console.WriteLine("Thank you for sharing about yourself, " + name + "!");
Console.WriteLine("Have a great day!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();