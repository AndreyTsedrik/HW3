System.Console.WriteLine("Введите координату X первой точки: ");
string s = Console.ReadLine();
int x1 = Int32.Parse(s);
System.Console.WriteLine("Введите координату Y первой точки: ");
string s2 = Console.ReadLine();
int y1 = Int32.Parse(s2);
System.Console.WriteLine("Введите координату Z первой точки: ");
string s3 = Console.ReadLine();
int z1 = Int32.Parse(s3);
System.Console.WriteLine("Введите координату X второй точки: ");
string s4 = Console.ReadLine();
int x2 = Int32.Parse(s4);
System.Console.WriteLine("Введите координату Y второй точки: ");
string s5 = Console.ReadLine();
int y2 = Int32.Parse(s5);
System.Console.WriteLine("Введите координату Z второй точки: ");
string s6 = Console.ReadLine();
int z2 = Int32.Parse(s6);

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double Length = Math.Sqrt (A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {Length}");