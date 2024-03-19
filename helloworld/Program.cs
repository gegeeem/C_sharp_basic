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


/*A string is an object of type String whose value is text. 
Internally, the text is stored as a sequential read-only collection of Char objects. 
There's no null-terminating character at the end of a C# string; 
therefore a C# string can contain any number of embedded null characters ('\0'). 
The Length property of a string represents the number of Char objects it contains, 
not the number of Unicode characters. 
To access the individual Unicode code points in a string, use the StringInfo object.*/

Console.WriteLine("Please, give me 7th character of string declared as greeting: "+greeting[6]);
Console.WriteLine("greetingLength: "+greeting.Length);

// null and empty string are diff

string iAmEmpty = "";
string iAmNull = null;
 
 if (iAmEmpty == iAmNull){
    Console.WriteLine("iAmEmpty == iAmNull true");
 }else{
    Console.WriteLine("iAmEmpty == iAmNull are not equal");
 }