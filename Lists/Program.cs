using System.Reflection.Metadata;

List<string> surnames = ["First","Second","Eighth", "Ninth"];
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

Console.WriteLine("Number of lements in Lists surnames is: "+surnames.Count);
var names1 =new List<string> {};// another way of declaration

Console.WriteLine("The first in list is "+surnames[0]);
Console.WriteLine("last is: "+surnames[^1]);

var names = new string[]{"Anna","Felipe"};
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


