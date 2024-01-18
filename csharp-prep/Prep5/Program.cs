using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //returnType FunctionName(paramType paramName1, paramType paramName2)
        //{
            //FunctionName body
        //}

        int Add2(int number){
            return number + 2;
        }

        int more = Add2(10);

        void PrintName(string name){
            System.Console.WriteLine($"Name is {name}");
            return;
        }

        PrintName("Bob");

        var y = 0;
        {
            var w =10;
            w = y + 4;
            y = w + 5;
        }
        y = w + 4;
    }
}