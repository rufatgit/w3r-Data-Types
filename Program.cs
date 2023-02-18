

Console.WriteLine("Enter 2 numbers to perform operations.");
double a=int.Parse(Console.ReadLine());
double b = int.Parse(Console.ReadLine());

Console.WriteLine("Which operation?");
char c=char.Parse(Console.ReadLine());


if (c=='+')
{
    Console.WriteLine(a+b);
}
else if (c=='-')
{
    Console.WriteLine(a-b);
}
else if (c=='/')
{
    Console.WriteLine(a/b);
}
else if(c=='*' || c=='x')
{
    Console.WriteLine(a*b);
}
else
{
    Console.WriteLine("Wrong char");
}









