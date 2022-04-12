Console.Write("Enter float number : ");
float num = float.Parse(Console.ReadLine());

//if (num == 0)
//    Console.WriteLine("Zero");
//else if (num < 0)
//    Console.WriteLine("Negative Small");
//else
//{
//    Console.WriteLine("Positive");
//    if (num > 1000000)
//        Console.WriteLine("Large");
//}

if (num == 0)
    Console.WriteLine("Zero");
else if (num < 0)
    Console.WriteLine("Negative Small");
else if (num > 1000000)
        Console.WriteLine("Positive Large");
    else
{
    Console.WriteLine("Positive");
   
}

