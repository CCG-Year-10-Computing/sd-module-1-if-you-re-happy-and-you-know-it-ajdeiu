// Program Name: 
// Created on: 
// Author: alicia

Console.WriteLine("please type in your % grade (from 1 to 100)");

int grade = Convert.ToInt32(Console.ReadLine());

if (grade > 100 || grade < 1)
{
    Console.WriteLine("please put in a number from 1 to 100");
}
else if (grade <= 100)
{
    Console.WriteLine("Congradulations, you got an A!!");
}
else if (grade <= 80 || grade >= 100)
{
    Console.WriteLine("you got a B");
}
