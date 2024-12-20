#region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number

//using System;

//Console.WriteLine("please enter value");
//int result;
//bool flag;
//flag=int.TryParse(Console.ReadLine(), out result);
//if (flag)
//    while (result>=1)
//    {
//        Console.WriteLine(result);
//        result--;
//    }
#endregion


#region 2 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.

//using System;

//Console.WriteLine("please enter inteager");
//int result;
//int.TryParse(Console.ReadLine(), out result);
//for (int i =1; i<=12;i++)
//{
//    Console.WriteLine($"{result}*{i}={result*i}");
//}

#endregion

#region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

//using System;
//Console.WriteLine("Please enter an integer: ");
//int number;
//bool flag = int.TryParse(Console.ReadLine(), out number);

//if (flag)
//{
//    int start = (number % 2 == 0) ? 2 : 1;

//    while (start <= number)
//    {
//        Console.WriteLine(start);
//        start += 2;
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input.");
//}


#endregion

#region - Write a program that takes two integers then prints the power.
//using System;

//Console.WriteLine("please enter number");
//int number;
//int.TryParse(Console.ReadLine(), out number);
//Console.WriteLine("please enter power");
//int exponent;
//int.TryParse(Console.ReadLine(), out exponent);

//double result=Math.Pow(number, exponent);
//Console.WriteLine(result);

#endregion


#region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
//using System;

//Console.WriteLine("Please enter the marks for 5 subjects.");
//Console.Write("Enter marks for subject 1: ");
//int subject1 = int.Parse(Console.ReadLine());

//Console.Write("Enter marks for subject 2: ");
//int subject2 = int.Parse(Console.ReadLine());

//Console.Write("Enter marks for subject 3: ");
//int subject3 = int.Parse(Console.ReadLine());

//Console.Write("Enter marks for subject 4: ");
//int subject4 = int.Parse(Console.ReadLine());

//Console.Write("Enter marks for subject 5: ");
//int subject5 = int.Parse(Console.ReadLine());


//int total;
//int.TryParse(Console.ReadLine(), out total);
//Console.WriteLine($"total: {subject1}+{subject2}+{subject3}+{subject4}+{subject5} ={ subject1+ subject2+ subject3+ subject4+ subject5}");
//double avarage;
//double.TryParse(Console.ReadLine(), out avarage);
//Console.WriteLine($"Average Marks= total / 5.0");
//double percentage;
//Double.TryParse(Console.ReadLine(), out percentage);
//Console.WriteLine($"Percentage: = (total / 500.0) * 100");
#endregion
#region 6 - Write a program to input the month number and print the number of days in that month. 
//using System;


//int month = int.Parse(Console.ReadLine());

//int days;

//switch (month)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        days = 31;
//        break;
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        days = 30;
//        break;
//    case 2:
//        days = 29;
//        break;
//    default:
//        Console.WriteLine("Invalid month number.");
//        return;
//}

//Console.WriteLine($"The number of days in month {month} is: {days}");

#endregion

#region 7- Write a program to create a Simple Calculator.
//using System;

//Console.WriteLine("Simple Calculator");
//Console.WriteLine("Enter the first number:");
//double num1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second number:");
//double num2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Select an operation:");
//Console.WriteLine("1. Add");
//Console.WriteLine("2. Subtract");
//Console.WriteLine("3. Multiply");
//Console.WriteLine("4. Divide");

//int operation = int.Parse(Console.ReadLine());

//double result = 0;

//switch (operation)
//{
//    case 1:
//        result = num1 + num2;
//        Console.WriteLine($"The result of {num1} + {num2} is: {result}");
//        break;
//    case 2:
//        result = num1 - num2;
//        Console.WriteLine($"The result of {num1} - {num2} is: {result}");
//        break;
//    case 3:
//        result = num1 * num2;
//        Console.WriteLine($"The result of {num1} * {num2} is: {result}");
//        break;
//    case 4:
//        if (num2 != 0)
//        {
//            result = num1 / num2;
//            Console.WriteLine($"The result of {num1} / {num2} is: {result}");
//        }
//        else
//        {
//            Console.WriteLine("Error! Division by zero is not allowed.");
//        }
//        break;
//    default:
//        Console.WriteLine("Invalid operation selected.");
//        break;
//}

#endregion

#region 8- Write a program to allow the user to enter int and print the REVERSED of it.
//using System;

//Console.WriteLine("Please enter an integer: ");
//int number = int.Parse(Console.ReadLine());

//int reversedNumber = 0;

//while (number != 0)
//{
//    int digit = number % 10;
//    reversedNumber = reversedNumber * 10 + digit;
//    number /= 10;
//}

//Console.WriteLine("The reversed number is: " + reversedNumber);
#endregion
