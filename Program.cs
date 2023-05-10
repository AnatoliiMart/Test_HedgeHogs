namespace Test_HedgeHogs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Attempts used: " + CalcHedgehogs(12,0,15, 1));
        }
        static public int CalcHedgehogs(uint rHedgehogs, uint gHedgehogs, uint bHedgehogs, int color )
        {
            int result = 0;
            uint[] hedgehogs = { rHedgehogs, gHedgehogs, bHedgehogs };
            switch (color)
            {
                case 0:
                    if (hedgehogs[1] == 0 && hedgehogs[2] == 0)
                         return -1;
                        
                    while (hedgehogs[1] >= 0 && hedgehogs[2] >= 0)
                    {

                        if (hedgehogs[1] == 1 && hedgehogs[2] == 0 || hedgehogs[1] == 0 && hedgehogs[2] == 1)
                            return -1;

                        if (hedgehogs[1] > 0 && hedgehogs[2] > 0)
                        {
                            hedgehogs[1]--;
                            hedgehogs[2]--;
                            hedgehogs[0] += 2;
                            result++;
                        }
                        else if (hedgehogs[1] > 0 && hedgehogs[2] == 0)
                        {
                            hedgehogs[1]--;
                            hedgehogs[0]--;
                            hedgehogs[2] += 2;
                            result++;
                        }
                        else if (hedgehogs[2] > 0 && hedgehogs[1] == 0)
                        {
                            hedgehogs[2]--;
                            hedgehogs[0]--;
                            hedgehogs[1] += 2;
                            result++;
                        }
                        else if (hedgehogs[1] == 0 && hedgehogs[2] == 0)
                            break;
                    }
                    break;
                case 1:
                    if (hedgehogs[0] == 0 && hedgehogs[2] == 0)
                        return -1;

                    while (hedgehogs[0] >= 0 && hedgehogs[2] >= 0)
                    {
                        if (hedgehogs[0] == 1 && hedgehogs[2] == 0 || hedgehogs[0] == 0 && hedgehogs[2] == 1)
                            return -1;

                        if (hedgehogs[0] > 0 && hedgehogs[2] > 0)
                        {
                            hedgehogs[0]--;
                            hedgehogs[2]--;
                            hedgehogs[1] += 2;
                            result++;
                        }
                        else if (hedgehogs[0] > 0 && hedgehogs[2] == 0)
                        {
                            hedgehogs[1]--;
                            hedgehogs[0]--;
                            hedgehogs[2] += 2;
                            result++;
                        }
                        else if (hedgehogs[2] > 0 && hedgehogs[0] == 0)
                        {
                            hedgehogs[2]--;
                            hedgehogs[1]--;
                            hedgehogs[0] += 2;
                            result++;
                        }
                        else if (hedgehogs[0] == 0 && hedgehogs[2] == 0)
                            break;
                    }
                    break;
                case 2:
                    if (hedgehogs[0] == 0 && hedgehogs[1] == 0)
                        return -1;

                    while (hedgehogs[0] >= 0 && hedgehogs[1] >= 0)
                    {
                        if (hedgehogs[0] == 1 && hedgehogs[1] == 0 || hedgehogs[0] == 0 && hedgehogs[1] == 1)
                            return -1;

                        if (hedgehogs[0] > 0 && hedgehogs[1] > 0)
                        {
                            hedgehogs[0]--;
                            hedgehogs[1]--;
                            hedgehogs[2] += 2;
                            result++;
                        }
                        else if (hedgehogs[0] > 0 && hedgehogs[1] == 0)
                        {
                            hedgehogs[2]--;
                            hedgehogs[0]--;
                            hedgehogs[1] += 2;
                            result++;
                        }
                        else if (hedgehogs[1] > 0 && hedgehogs[0] == 0)
                        {
                            hedgehogs[1]--;
                            hedgehogs[2]--;
                            hedgehogs[0] += 2;
                            result++;
                        }
                        else if (hedgehogs[0] == 0 && hedgehogs[1] == 0)
                            break;
                    }
                    break;
            }


           

            Console.WriteLine($"Red hedgehogs left:   {hedgehogs[0]}\n" +
                              $"Green hedgehogs left: {hedgehogs[1]}\n" +
                              $"Blue hedgehogs left:  {hedgehogs[2]}\n");
            return result;
        }
    }
}