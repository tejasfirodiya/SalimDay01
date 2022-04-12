Console.Write("Enter 3 numbers : ");
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());

Console.WriteLine("First Number : " + firstNum + "\tSecond Numb" +
    "er : " + secondNum + "\t Third Number : " + thirdNum);

//int result =  firstNum > secondNum ? secondNum > thirdNum ? firstNum : secondNum : thirdNum;
//Console.WriteLine(result);

//string result1 = firstNum > secondNum ? "firstnum is greater" : "second number is greater";
//Console.WriteLine(result1);

if(firstNum >= secondNum && firstNum >= thirdNum)
{
    if (firstNum == secondNum)
        Console.WriteLine(firstNum + " is equal to "+ secondNum);
    else if(firstNum == thirdNum)
        Console.WriteLine(firstNum + " is equal to " + thirdNum);
    else
    Console.WriteLine(firstNum + "is greater");
}
else if(secondNum >= firstNum && secondNum >= thirdNum)
{
    if (secondNum == firstNum)
        Console.WriteLine(secondNum + " is equal to " + firstNum);
    else if (secondNum == thirdNum)
        Console.WriteLine(secondNum + " is equal to " + thirdNum);
    else
        Console.WriteLine(secondNum + "is greater");
}
else if (thirdNum >= firstNum && thirdNum >= secondNum)
{
    if (thirdNum == firstNum)
        Console.WriteLine(thirdNum + " is equal to " + firstNum);
    else if (thirdNum == secondNum)
        Console.WriteLine(thirdNum + " is equal to " + secondNum);
    else
        Console.WriteLine(thirdNum + "is greater");
}
else
{
    Console.WriteLine($"{firstNum}, {secondNum}, {thirdNum} are equal.");
}