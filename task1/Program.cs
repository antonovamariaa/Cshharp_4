int PowerResult (int num, int pow) {
    int result = 1; 
    int i = 0;
    while (i<pow) {
        result = result*num;
        i++;}
    return result;}

int Number (string text) {
    System.Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Power (string text) {
    System.Console.Write(text);
    int pow = Convert.ToInt32(Console.ReadLine());
    return pow;
}

int num = Number("input number: ");
int pow = Power ("input power: ");
int result = PowerResult(num, pow);

if (pow>0){System.Console.WriteLine(result);}
else if (pow == 0){System.Console.WriteLine(1);}
else {System.Console.WriteLine("error");}


