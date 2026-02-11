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
else if (grade <= 80 || grade > 100)
{
    Console.WriteLine("you got a B");
}
else if (grade <= 60 || grade > 80)
{
    Console.WriteLine("you got a C");
}
else if (grade <= 40 || grade > 60)
{
    Console.WriteLine("you got a D");
}
else if (grade <= 20 || grade > 40)
{
    Console.WriteLine("you got a E");
}
else if (grade <= 0 || grade > 20)
{
    Console.WriteLine("you got a F");
}
else if (grade = 100000000000000000)
{
    Console.WriteLine("pooja what is this behavior?");
    Console.WriteLine("sorry i kicked it by mistake");
    Console.WriteLine("no you cnat kick it by mistake");
    Console.WriteLine("well pick it up if it bothers you");
    Console.WriteLine("no you pick it up");
}
    


