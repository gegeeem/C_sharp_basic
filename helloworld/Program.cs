// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! I'm here!");

string firstFriend = "Maria";
string secondFriend = "Scott";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine("My friend is "+firstFriend+" and "+secondFriend);


//Trim() method
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
