
//Ex 1. Write a C# Sharp program that takes three letters as input and display them in reverse order.
Console.WriteLine("Enter 3 chars");
string[] input=Console.ReadLine().Split(' ');
char[] chars=Array.ConvertAll(input, char.Parse);

chars = chars.Reverse().ToArray();

foreach (char c in chars)
{
    Console.Write(c+" ");
}




//Ex 2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. 
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the desired width");
int width = Convert.ToInt32(Console.ReadLine());



for (int j = 0; j < width; j++)
{
    for (int i = j; i < width; i++)
    {
        Console.Write(number);
    }
    Console.WriteLine();
}

 


//Ex 3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
string id = "345";
string password = "blabla345";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter ID: ");
    string check_id = Console.ReadLine();

    Console.WriteLine("Enter password: ");
    string check_password = Console.ReadLine();


    if (check_id == id && check_password == password)
    {
        Console.WriteLine("Correct!");
        break;

    }
    else if (i == 2)
    {
        Console.WriteLine("Incorrect. So many attempts. Reset Password?");
    }
    else
    {
        Console.WriteLine($"Incorrect. {3 - i - 1} attemps left. Try again.");
        continue;
    }

}


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


//Ex- 6. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).
Console.WriteLine("Values range of function: x=y^2-2y+1");


for (int i = -5; i <= 5; i++)
{
    Console.WriteLine($"y={i}, x={i}^({i})+2{i}+1={i * i - 2 * i + 1}");
}

//Ex - 7. Write a C# Sharp program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour.

Console.WriteLine("Input distance(metres)");
double distance_metres = double.Parse(Console.ReadLine());

double distance_in_km = distance_metres / 1000;
double distance_in_miles=distance_metres / 1609.34;

Console.WriteLine("Input Time(hour)");
double hour = double.Parse(Console.ReadLine());

Console.WriteLine("Input minutes");
double minute = double.Parse(Console.ReadLine());

Console.WriteLine("Input seconds");
double second = double.Parse(Console.ReadLine());


double time_in_seconds = second + minute * 60 + hour * 60 * 60;
double time_in_hours = hour + minute / 60 + second / 60 / 60;

Console.WriteLine("Your speed in metres/sec is "+distance_metres/time_in_seconds);
Console.WriteLine("Your speed in km/h is "+distance_in_km/time_in_hours);
Console.WriteLine("Your speed in miles/h is "+distance_in_miles/ time_in_hours);

//Ex 8 - Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.

Console.WriteLine("Enter radius of sphere: ");
double rad = double.Parse(Console.ReadLine());

double pi = 3.1415926535;

Console.WriteLine("Surface area: " + 4 * pi * rad * rad);
Console.WriteLine("Volume: " + (4 / 3) * pi * Math.Pow(rad, 3));

//Ex 9 - Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.

Console.WriteLine("Enter char:");
char symbol=char.Parse(Console.ReadLine());

if (symbol=='a' || symbol=='e' || symbol=='i' || symbol=='o' || symbol=='u')
{
    Console.WriteLine("It's a lowercase vowel.");
}
else if (char.IsDigit(symbol))
{
    Console.WriteLine("It's a digit.");
}
else
{
    Console.WriteLine("Another symbol.");
}

//Ex 10 - Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
Console.WriteLine("Enter 2 numbers:");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());


if (a%2==0 && b%2==0)
{
    Console.WriteLine("Both are even");
}
else
{
    Console.WriteLine("One of them or both of them are odd");
}

//Ex 11 - Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.

Console.WriteLine("Enter number");
int a=int.Parse(Console.ReadLine());

Console.WriteLine(Convert.ToString(a, 2));















