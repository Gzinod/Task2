
 Console.WriteLine("input num1");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("input num2");
 int num2 = Convert.ToInt32(Console.ReadLine());
 if (num1 % num2 == 0)
 {
    Console.WriteLine("OK");
 }
 else Console.WriteLine($"остаток{num1 %num2}");