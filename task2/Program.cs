int Count (string text) {
    System.Console.WriteLine(text);
    int num = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
    int sum = 0;
    int i = 0;
    while (num>0) {
        sum += num%10;
        num = num/10;
        i++;}
    return sum;}

System.Console.WriteLine(Count("input number: "));
