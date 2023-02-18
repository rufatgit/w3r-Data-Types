
//4. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.

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

//Ex - 5. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle. 
Console.WriteLine("Enter radius of Circle");
double rad = double.Parse(Console.ReadLine());

double pi = 3.14;

Console.WriteLine("Circumference: "+2*pi*rad);

Console.WriteLine("Area of circle: "+pi*Math.Pow(rad,2));







