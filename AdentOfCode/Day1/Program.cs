namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new();
            Console.WriteLine("Day 1 started. Welcome Elves \n" + program.Elves("elves.txt"));
        }

        public int Elves(string file)
        {
            int res = 0;
            int temp = 0;
            var lines = File.ReadLines(file);
            var last = lines.Last();
            foreach (var line in lines)
            {
                if (line == "")
                {
                    if (temp > res) res = temp;
                    temp = 0;
                    break;
                }

                if (line.Equals(last))
                {
                    temp = temp + Int32.Parse(line);
                    if (temp > res) res = temp;
                    return res;
                }
                temp = temp + Int32.Parse(line);
            }
            return res;
        }

    }
}