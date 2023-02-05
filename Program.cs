Console.WriteLine("Input three-digit number\n");
int a = Convert.ToInt32(Console.ReadLine());
a=a%100;

Console.WriteLine($"{a/10}");
