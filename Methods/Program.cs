WorkWithIntegers();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
    int max = int.MaxValue;
    Console.WriteLine("Max int value: "+max);
    int d = int.Min(a,b);
    Console.WriteLine("int d = int.Min(a,b): "+d);
    int what = max + 3;
   /* int g = 10000000000; Cannot implicitly convert type 'long' to 'int'.*/
   /*long g = 10000000000000000000; Cannot implicitly convert type 'ulong' to 'long'*/
   ulong g = 10000000000000000000; /*it s fine*/
Console.WriteLine($"An example of overflow: {what}");
}