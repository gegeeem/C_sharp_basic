using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata;

List<string> surnames = ["First","Second","Eighth", "Ninth"];
List<string> pointSurnames = surnames;
surnames.Add("Thrid");
surnames.Add("Fourth");
surnames.Remove("Third"); // not works, probably  there is no "Third" in the List yet
surnames.Remove("Second");// it works
surnames.RemoveAt(1);// remove by index
surnames.Sort();
foreach(var surname in surnames[1..3]){
    Console.WriteLine("range surnames[1..3]; "+surname);
};
foreach(string surname in surnames){
    Console.WriteLine(surname);

}
foreach(string point in pointSurnames){
    Console.WriteLine("pointSurnames: "+point);

}


Console.WriteLine("Number of lements in Lists surnames is: "+surnames.Count);
var names1 =new List<string> {};// another way of declaration

Console.WriteLine("The first in list is "+surnames[0]);
Console.WriteLine("last is: "+surnames[^1]);

var names = new string[]{"Anna","Felipe","Amelia"};
Console.WriteLine("string.Contains "+names.Contains("Em"));
var pointNames = names;// same point to names
names = [..names, "Maria"];// diff point, new arra is generated
/*array are immutable, list are not*/
foreach(string name in names){
    Console.WriteLine("array .names after adding member: "+name);
};
foreach(String name in pointNames){
    Console.WriteLine("point names: "+name);

}
var compareToStr = names[2].CompareTo("Anna");
Console.WriteLine("compareTo: " +compareToStr);


