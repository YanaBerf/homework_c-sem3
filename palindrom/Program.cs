Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int n1 = num / 10000;
int n2 = num / 1000 % 10;
int n3 = num / 100 % 10;
int n4 = num / 10 % 10;
int n5 = num % 10;

if (n1 == n5 && n2 == n4){
    Console.WriteLine($"{num} -> да");
}
else {
    Console.WriteLine($"{num} -> нет");
}

