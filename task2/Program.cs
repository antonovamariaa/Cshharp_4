System.Console.Write("input number: ");
string str = Console.ReadLine();
int i = 0;
int num = int.Parse(str);
int sum = 0;

while (i<str.Length) {
    sum += num%10;
    num = num/10;
    i++;
}
System.Console.WriteLine(sum);