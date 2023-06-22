System.Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input power: ");
int pow = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0;

while (i<pow) {
    result = result*num;
    i++;
}
System.Console.WriteLine(result);
