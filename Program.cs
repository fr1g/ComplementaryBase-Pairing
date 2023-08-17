namespace CBP {
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{args is null}, input args: {args}, Actual length: {args.Length}\n");
            Console.WriteLine("\n速来进行碱基互补配对！会跳过非ACGT的字符，仅限于人教版教科书上说的替换哦。\n输入“0”来退出。");
            if ( args.Length > 0)
            {
                string pre = "";
                if (args.Length > 1) foreach (var inj in args)
                    {
                        pre += $"{inj} ";
                    }
                else pre = args[0];
                Console.WriteLine($"\n返回的结果是：\n{Worker(pre)}");
            }
            while (true)
            {
                Console.WriteLine("======\n");
                String Input = Console.ReadLine();
                switch (Input)
                {
                    case "0":
                        Console.WriteLine("\n白白! \n");
                        Thread.Sleep(500);
                        return;
                    default:
                        if (Input is null || Input == "")
                        {
                            Console.WriteLine("巧妇难为无米之炊哇\n");
                            break;
                        }
                        Console.WriteLine($"返回的结果是：\n{Worker(Input)}");
                        break;
                }
            }
        }
    
        private static string Worker(string input)
        {
            char[] chars = input.ToCharArray();
            string complete = "";
            foreach (char c in chars)
                switch (c)
                {
                    case 'A':
                        complete += "T";
                        break;
                    case 'a':
                        complete += "t";
                        break;
                    case 'T':
                        complete += "A";
                        break;
                    case 't':
                        complete += "a";
                        break;
                    case 'G':
                        complete += "C";
                        break;
                    case 'g':
                        complete += "c";
                        break;
                    case 'C':
                        complete += "G";
                        break;
                    case 'c':
                        complete += "g";
                        break;

                    default:
                        complete += c;
                        break;
                }
            complete += "\n";
            return complete;
        }
    
    
    }
}