int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;

Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;

Console.WriteLine("The range of integers is {min} to {max}.");
// intersting the $ sign !!!
Console.WriteLine($"The range of integers is {min} to {max}.");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what} is 3 more then {max} interestingly 2 more then {min} I wonder?");

int wonder = max + 1;
Console.WriteLine($"So what is this then? {wonder}");
// oh werid