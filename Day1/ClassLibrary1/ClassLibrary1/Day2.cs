using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Day2
    {
       
        public static int GetAnswer1(string input)
        {
            return input.Split(Environment.NewLine)
                .Sum(x => (
                        (int)GetResult(GetMove(x[0]), GetMove(x[2])) +
                        (int)GetMove(x[2])
                        ));
        }


        private static Result GetResult(Move oponent, Move me)
        {
            if (oponent == Move.Rock)
            {
                switch (me)
                {
                    case Move.Rock:
                        return Result.Draw;
                    case Move.Paper:
                        return Result.Win;
                    case Move.Scisors:
                        return Result.Lose;
                }
            }
            if (oponent == Move.Paper)
            {
                switch (me)
                {
                    case Move.Rock:
                        return Result.Lose;
                    case Move.Paper:
                        return Result.Draw;
                    case Move.Scisors:
                        return Result.Win;
                }
            }
            if (oponent == Move.Scisors)
            {
                switch (me)
                {
                    case Move.Rock:
                        return Result.Win;
                    case Move.Paper:
                        return Result.Lose;
                    case Move.Scisors:
                        return Result.Draw;
                }
            }
            throw new ArgumentOutOfRangeException("Not a valid Move combination");
        }

        private static Move GetMove(char input)
        {
            switch (input)
            {
                case 'A':
                    return Move.Rock;
                case 'X':
                    return Move.Rock;
                case 'B':
                    return Move.Paper;
                case 'Y':
                    return Move.Paper;
                case 'C':
                    return Move.Scisors;
                case 'Z':
                    return Move.Scisors;
            }
            throw new ArgumentOutOfRangeException(nameof(input));
        }

        private enum Move { 
            Rock = 1,
            Paper = 2,
            Scisors = 3
        }

        private enum Result { 
            Lose = 0,
            Draw = 3,
            Win = 6
        }
    }
}
