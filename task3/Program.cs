//fill, no return
void Fillarray(int[] arr, int len, int min, int max){
    Random rand = new Random();
    for (int i = 0; i<len; i++){
    arr[i] = rand.Next(min,max);}}

//print, no return
void Printarray(int[] arr){
    System.Console.WriteLine(string.Join(" ", arr));}

//input max number, return nummax
int Maxnum (string text) {
    System.Console.Write(text);
    int max = Convert.ToInt32(System.Console.ReadLine());
    return max;}

//input min number, return nummin
int Minnum (string text) {
    System.Console.Write(text);
    int min = Convert.ToInt32(System.Console.ReadLine());
    return min;}

//input array length, return arlen
int Length (string text) {
    System.Console.Write(text);
    int arlen = Convert.ToInt32(System.Console.ReadLine());
    return arlen;}

//--------------------------------------------------------------------------------------------

int arlen = Length("input length: ");
int minnum = Minnum("input minimal number: ");
int maxnum = Maxnum("input maximum number: ")+1;


int[] array = new int[arlen];
Fillarray(array, arlen, minnum, maxnum);
Printarray(array);