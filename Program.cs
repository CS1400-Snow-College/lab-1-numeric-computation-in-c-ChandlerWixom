Console.WriteLine("Please Input Radius to find Area of Circle");
double inputradius = Convert.ToDouble(Console.ReadLine());
// apparently you can convert strings into other things with convert.to
Console.WriteLine($"The area is {inputradius * inputradius * Math.PI}.");
