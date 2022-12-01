namespace ClassLibrary1
{
    public static class Class1
    {
        public static int GetAnswer1(string input)
        {
            var elves = GetElves(input);

            return elves.Max();
        }

        public static int GetAnswer2(string input)
        {
            var elves = GetElves(input);

            return elves.OrderByDescending(x => x).Take(3).Sum();
        }

        private static IEnumerable<int> GetElves(string input)
        {
            var elf = 0;
            var elves = new List<int>();
            foreach (var line in input.Split(Environment.NewLine))
            {
                if (line == "")
                {
                    elves.Add(elf);
                    elf = 0;
                    continue;
                }
                elf += int.Parse(line);
            }
            elves.Add(elf);
            return elves;
        }
    }
}