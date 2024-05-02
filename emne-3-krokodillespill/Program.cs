// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

Console.WriteLine("Krokodille spill!");

Random random = new Random();
int points = 0;


int randomNum()
{
    int num = random.Next(1, 12);
    return num;
}


void gameLogic()
{
    
    int num1 = randomNum();
    int num2 = randomNum();

    Console.WriteLine($"Which number is bigger or are they equal? {num1}_{num2}");
    var answer = Console.ReadLine();

    if (answer != "=" && answer != "<" && answer != ">")
    {
        Environment.Exit(0);
    } else if  (num1 == num2 && answer == "=") {
        points++;
        Console.WriteLine($"Congratulations here is a point {points}");
        gameLogic();
    } else if (num1 > num2 && answer == ">")
    {
        points++;
        Console.WriteLine($"Congratulations here is a point {points}");
        gameLogic();
    } else if (num1 < num2 &&  answer == "<")
    {
        points++;
        Console.WriteLine($"Congratulations here is a point {points}");
        gameLogic();
    } else
    {
        points--;
        Console.WriteLine($"Yeah no that is wrong I'm taking a point from you {points}");
        gameLogic();
    }

}
gameLogic();
