using System;
using System.Threading;

namespace RockPaperScissors
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }
    public enum Result
    {
        Win,
        Lose,
        Draw,
        Undefined
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("yamen", 60, 0);
            Player computer = new Player("robot", 80, 0);

            for (int i = 0; i < 10; i++)
            {
                Choice playerChoice = player.GetChoice();
                Choice computerChoice = computer.GetChoice();
                Console.WriteLine($"Player pick {playerChoice} and Computer pick {computerChoice}");

                if (Player.GetResult(playerChoice, computerChoice) == Result.Win)
                {
                    Console.WriteLine($"Player won");
                    player.Point++;
                }
                else if (Player.GetResult(playerChoice, computerChoice) == Result.Lose)
                {
                    Console.WriteLine($"Player lost");
                    computer.Point++;
                }
                else
                {
                    Console.WriteLine("It`s draw!");
                }

                Console.WriteLine();
                Thread.Sleep(5000);
            }
        }
    }
    public class Player
    {
        private string Name;
        private int point;
        private int X = 0;
        private int Y = 0;

        public int Point 
        {
            get 
            {
                return point;
            }
            set 
            {
                int oldY = Console.CursorTop;
                int oldX = Console.CursorLeft;

                point = value;
                Console.CursorTop = Y;
                Console.CursorLeft = X;
                Console.Write($"{Name} : {point} points");

                Console.CursorTop = oldY;
                Console.CursorLeft = oldX;
            } 
        }

        public Player(string name, int x, int y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public static Result GetResult(Choice player, Choice computer)
        {
            if (player == computer)
            {
                return Result.Draw;
            }
            if (player == Choice.Paper)
            {
                if (computer == Choice.Rock)
                {
                    return Result.Win;
                }
                if (computer == Choice.Scissors)
                {
                    return Result.Lose;
                }
            }
            if (player == Choice.Rock)
            {
                if (computer == Choice.Scissors)
                {
                    return Result.Win;
                }
                if (computer == Choice.Paper)
                {
                    return Result.Lose;
                }
            }
            if (player == Choice.Scissors)
            {
                if (computer == Choice.Paper)
                {
                    return Result.Win;
                }
                if (computer == Choice.Rock)
                {
                    return Result.Lose;
                }
            }
            return Result.Undefined;
        }
        public Choice GetChoice()
        {
            Random random = new Random();
            int val = random.Next(0, 3);
            return (Choice)val;
        }
    }
}
