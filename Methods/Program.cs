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
    Console.WriteLine($"An example of overflow: {what}");


    long f = 100_0000_000_000_000_000; // 
   /* int g = 10000000000; Cannot implicitly convert type 'long' to 'int'.*/
   /*long g = 10000000000000000000; Cannot implicitly convert type 'ulong' to 'long'*/
   ulong g = 10_000_000_000_000_000_000; /*it s fine*/
   //int n = checked(max+ 3);
   float a1  = 45.0F;
   double a2 = 4.5;
   
   Console.WriteLine("long f = "+f+", ulong g = "+g+", float a1 = "+a1+" type: "+ a2.GetType());
   Console.WriteLine(l);
}