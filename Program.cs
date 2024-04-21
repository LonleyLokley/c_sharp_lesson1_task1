int val = 100;
long vall = 2*100500;
double b = 6.6;
char c = '!';
bool tr = true;
string text = "tect";



Console.WriteLine(c);
Console.WriteLine(b);

Console.WriteLine(val);
Console.WriteLine(tr);

Console.WriteLine(text);
Console.WriteLine(vall);


int a = 5;
int bb = 10;

if (a>bb) {
    Console.WriteLine(false);
}
else {
    Console.WriteLine(true);
}

See https://aka.ms/new-console-template for more informatstr

Console.Write("Введите перое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
 Console.WriteLine(true);
}
else
{
 Console.WriteLine(false);
}



Console.Write("Enter a numder ");
int n =  Convert.ToInt32(Console.ReadLine());
int count = -n; //n*(-1)
while (count<=n)
{
Console.Write(count + " ");
 count++;
}





int n =  Convert.ToInt32(Console.ReadLine());
if (n>=100 && n<=999) {
    int furst = n/100;
int last = n % 10;
int res = furst+last;


Console.WriteLine($"result is {res}");
}

else {
    Console.Write($"the num {n} ni too math");
}




