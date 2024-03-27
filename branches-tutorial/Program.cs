using System.Security.Cryptography;

int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");
   Console.WriteLine(a > b ? "ok": "no");

   //
   int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
//
int counter2 = 0;
do
{
    Console.WriteLine($"Hello World! The counter2 is {counter2}");
    counter2++;
} while (counter2 < 10);

//
for (int index = 0; index < 10; index++)
{
    Console.WriteLine($"Hello World! The index is {index}");
}
//nesting loops
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
for(int i = 1, sum = 0; i <= 20; i++){
    if(i % 3 == 0){
        sum += i;
        Console.WriteLine(sum);
    }

}
List<string> names = ["ka", "mi", "vi"];
List<> imena = [];