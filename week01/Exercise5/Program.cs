using System;

class Program
{
    // O ponto de entrada principal do programa
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    // Exibe a mensagem de boas-vindas
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Pede o nome do usuário
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Pede o número favorito do usuário
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Calcula o quadrado do número
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    // Exibe o resultado final
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
    }
}