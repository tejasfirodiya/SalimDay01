//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("\t\t\tVariables and Datatypes\t\t\t");

////var a = 10;
////a = 20;
////a = "Hello";
////Console.WriteLine(a);
////Console.WriteLine(A);

//Console.WriteLine("\t\t\tType Casting => Implicit, Explicit\t\t\t");

// /*Console.WriteLine(a);*/
//Console.WriteLine("\nSize of integer : " + sizeof(int));
//string a = "hello";

////Console.WriteLine("\nSize of string : " + sizeof(string));

//Console.WriteLine("\nSize of char : " + sizeof(char));
//Console.WriteLine("\nSize of double : " + sizeof(double));

//Console.WriteLine("\nSize of float : " + sizeof(float));
//Console.WriteLine("\nSize of bool : " + sizeof(bool));

//int z = 10;
//long c = z;
//Console.WriteLine(c);


////Explicit Conversion
//Console.WriteLine("\nExplicit Conversion\n");
//double myDouble = 9.78;
//int myInt = (int)myDouble;    // Manual casting: double to int
//Console.WriteLine(myDouble);
//Console.WriteLine(myInt);

//long myLong = 2147483647;
//int myInt2 = (int)myLong;    // Manual casting: long to int
//Console.WriteLine(myLong);
//Console.WriteLine(myInt2);

//float myFloat = 9745.855335F;
//int myInt3 = (int)myFloat;    // Manual casting: float to int
//Console.WriteLine(myFloat);
//Console.WriteLine(myInt3);

//int abc = 2147483647;

//Console.WriteLine(abc);
//abc += 1;
//Console.WriteLine(abc);
//Console.WriteLine("==================================================================================");
//Console.WriteLine("\t\t\tString and String Functions\t\t\t");

//string s = "hello \"my\"";
//Console.WriteLine(s.ToLower());
//Console.WriteLine(s.ToUpper());
//Console.WriteLine(char.ToUpper(s[0]) + s.Substring(1));

//string s1 = "11,12,13,14";
//string s2 = s1.Split(',')[2];
//string []s3 = s1.Split(',');  //OR
//Console.WriteLine(s2);
//Console.WriteLine(s3[3]);
//Console.WriteLine("==================================================================================");


//s = "12 13 14 15";

//var a = "Hello";
//var b = " World";
//var c = " My";
//var d = " Know";
//Console.WriteLine(a+b+c+d);
//Console.WriteLine("Value of a : " + a + "\nValue of b : " + b + "\nValue of c : " + c + "\nValue of d : " + d);
//Console.WriteLine("==================================================================================");

//Cosnole.Write("\t\t\tEscape Sequence\t\t\t");
//Console.WriteLine("Hello\rmy");

//Cosnole.Write("\t\t\tIf condition\t\t\t");
//int a = 10;
//if(true)
//{
//    Console.WriteLine("Tejas");
//}

//Console.Write("Enter a number : ");
//int a = int.Parse(Console.ReadLine());
//if (a % 5 == 0)
//    Console.WriteLine(a + " is is divided by 5");
//else
//    Console.WriteLine(a + " is not divided by 5");

//Console.Write("Enter a number : ");
//int a = int.Parse(Console.ReadLine());
//if(a%5==0)
//{
//    if(a%2==0)
//        Console.WriteLine(a + " is is divided by 5 & divided by 2");
//    else
//        Console.WriteLine(a + " is divided by 5 but not divided by 2");
//}

//Console.Write("Enter a number : ");
//int a = int.Parse(Console.ReadLine());

//if (a == 0)
//    Console.WriteLine("Sunday");
//else if (a == 1)
//    Console.WriteLine("Monday");
//else if (a == 2)
//    Console.WriteLine("Tuesday");
//else if (a == 3)
//    Console.WriteLine("Wednesday");
//else if (a == 4)
//    Console.WriteLine("Thursday");
//else if (a == 5)
//    Console.WriteLine("Friday");
//else if (a == 6)
//    Console.WriteLine("Saturday");
//else
//    Console.WriteLine("input is incorrect ");

//Console.WriteLine("==================================================================================");

//Console.Write("Enter a month : ");
//int month = int.Parse(Console.ReadLine());

//if (month == 0)
//    Console.WriteLine("31 days in January");
//else if (month == 1)
//    Console.WriteLine("28 days in February");
//else if (month == 2)
//    Console.WriteLine("31 days in March");
//else if (month == 3)
//    Console.WriteLine("30 days in April");
//else if (month == 4)
//    Console.WriteLine("31 days in May");
//else if (month == 5)
//    Console.WriteLine("30 days in June");
//else if (month == 6)
//    Console.WriteLine("31 days in July");
//else if (month == 7)
//    Console.WriteLine("31 days in August");
//else if (month == 8)
//    Console.WriteLine("30 days in September");
//else if (month == 9)
//    Console.WriteLine("31 days in October");
//else if (month == 10)
//    Console.WriteLine("30 days in November");
//else if (month == 11)
//    Console.WriteLine("31 days in December");
//else
//    Console.WriteLine("input is incorrect ");
//Console.WriteLine("==================================================================================");

//Console.Write("Enter a month like January : ");
//var monthText = Console.ReadLine().ToLower();

//Console.Write("Enter a month in number from 0-11: ");
//int monthNum = int.Parse(Console.ReadLine());

//if (monthText == "january" && monthNum==0)
//    Console.WriteLine("31 days in January");
//else if (monthText == "february" && monthNum == 1 )
//    Console.WriteLine("28 days in February");
//else if (monthText == "march" && monthNum == 2)
//    Console.WriteLine("31 days in March");
//else if (monthText == "april" && monthNum == 3)
//    Console.WriteLine("30 days in April");
//else if (monthText == "may" && monthNum == 4)
//    Console.WriteLine("31 days in May");
//else if (monthText == "june" && monthNum == 5)
//    Console.WriteLine("30 days in June");
//else if (monthText == "july" && monthNum == 6)
//    Console.WriteLine("31 days in July");
//else if (monthText == "august" && monthNum == 7)
//    Console.WriteLine("31 days in August");
//else if (monthText == "september" && monthNum == 8)
//    Console.WriteLine("30 days in September");
//else if (monthText == "october" && monthNum == 9)
//    Console.WriteLine("31 days in October");
//else if (monthText == "november" && monthNum == 10)
//    Console.WriteLine("30 days in November");
//else if (monthText == "december" && monthNum == 11)
//    Console.WriteLine("31 days in December");
//else
//    Console.WriteLine("input is incorrect ");
//Console.WriteLine("==================================================================================");
Console.Write("Enter a month in number from 0-11: ");
float monthNum = float.Parse(Console.ReadLine());

switch(monthNum)
{
    case 1.2F:
        Console.WriteLine("CASE 1");
        break;
    case 2:
        Console.WriteLine("CASE 2");
        break;
    case 3:
        Console.WriteLine("CASE 3");
        break;
    default: Console.WriteLine("DEFAULT");
        break;
}
//Console.WriteLine("==================================================================================");
Console.Write("Enter a month in number from 0-11: ");
string month = Console.ReadLine();
//char month = char.Parse(Console.ReadLine());

switch (month)
{
    //case 'a':
    //    Console.WriteLine("january");
    //    break;
    case "january":
        Console.WriteLine("january");
        break;
    case "february":
        Console.WriteLine("february");
        break;
    case "march":
        Console.WriteLine("march");
        break;
    case "april":
        Console.WriteLine("april");
        break;
    case "may":
        Console.WriteLine("may");
        break;
    case "june":
        Console.WriteLine("june");
        break;
    case "july":
        Console.WriteLine("july");
        break;
    case "august":
        Console.WriteLine("august");
        break;
    case "september":
        Console.WriteLine("september");
        break;
    case "october":
        Console.WriteLine("october");
        break;
    case "november":
        Console.WriteLine("november");
        break;
    case "december":
        Console.WriteLine("december");
        break;
    default:
        Console.WriteLine("DEFAULT");
        break;
}



//if (monthText == "january")
//    Console.WriteLine("31 days in January");
//else if (monthText == "february")
//{
//    if ((year % 4) == 0)
//        Console.WriteLine("As this is leap year. So 29 days in February");
//    else
//        Console.WriteLine("As this is not a leap year. So 28 days in February");
//}
//else if (monthText == "march")
//    Console.WriteLine("31 days in March");
//else if (monthText == "april")
//    Console.WriteLine("30 days in April");
//else if (monthText == "may")
//    Console.WriteLine("31 days in May");
//else if (monthText == "june")
//    Console.WriteLine("30 days in June");
//else if (monthText == "july")
//    Console.WriteLine("31 days in July");
//else if (monthText == "august")
//    Console.WriteLine("31 days in August");
//else if (monthText == "september")
//    Console.WriteLine("30 days in September");
//else if (monthText == "october")
//    Console.WriteLine("31 days in October");
//else if (monthText == "november")
//    Console.WriteLine("30 days in November");
//else if (monthText == "december")
//    Console.WriteLine("31 days in December");
//else
//    Console.WriteLine("Input is incorrect. Please Check!!");


