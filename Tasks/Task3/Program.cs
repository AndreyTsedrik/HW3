Console.WriteLine("Введите число N: ");
string s = Console.ReadLine();
int number = Int32.Parse(s);

for (int i = 1; i <= number; i ++)
{ 
 Console.WriteLine ($"{i*i*i} ");
}

