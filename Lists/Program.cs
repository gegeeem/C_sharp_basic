List<string> surnames = ["First","Second"];
surnames.Add("Thrid");
surnames.Add("Fourth");
surnames.Remove("Third"); // not works, probably  there is no "Third" in the List yet
surnames.Remove("Second");// it works
surnames.RemoveAt(1);// remove by index
surnames.Sort();
foreach(string surname in surnames){
    Console.WriteLine(surname);

}

Console.WriteLine("Number of lements in Lists surnames is: "+surnames.Count);
var names =new List<string> {};// another way of declaration

Console.WriteLine("The first in list is "+surnames[0]);