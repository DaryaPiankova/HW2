
Console.WriteLine("Input an integer\n");
string a = Console.ReadLine();
if(a.Length<3){
    Console.WriteLine("There is no third number in the integer\n");
}else{
Console.WriteLine($"{a[2]}\n");
}
