System.Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input power >= 0: ");
int pow = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0;
if (pow<0){System.Console.WriteLine("error");}
else if (pow == 0){System.Console.WriteLine(1);}
else {
    while (i<pow) {
    result = result*num;
    i++;
}}
System.Console.WriteLine(result);
