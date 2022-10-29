using System;

namespace BaseLab_10
{
    class Program
    {
        static void Main()

        {
            while (true)
            {
                //Console.WriteLine("Введите число:");
                //int v = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Введите систему счисления");
                //int x = Convert.ToInt32(Console.ReadLine());
                //From10(v,x);

                Console.WriteLine("Введите систему счисления");
                int x = Convert.ToInt32(Console.ReadLine());
                string[] chars = new string[0];
                string current = "";

                while(true)
                 {
                    current = Console.ReadLine();
                    if (current != "*")
                    {
                        chars = new string[chars.Length + 1];
                        chars[^1] = current;
                    }
                    else
                    {
                        break;
                    }
                }
                 

                int[] result = ToInt(chars, x);
                foreach (var i in result)
                {
                    Console.Write(i + " ");
                }
               

            }

            static void To10(int v, int x)

            {

            }
            static int[] ToInt(string[] chars, int rang)
                
            {
                int[] result = new int[chars.Length];
                for(int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == "10")
                    {
                        result[i] = rang;
                    }
                    else if(int.TryParse(chars[i], out int res))
                    {
                        if(res < 10)
                        {
                            result[i] = res;
                        }
                        else
                        {
                            result[i] = res + rang - 10;
                        }
                    }
                    result[i] = (char)(chars[i][0] + 55);
                        
                }
                return result;
            }
            static void From10(int v, int x)
            {
                int a = 0;
                int i = 0;
                string[] b = new string[10];
                while (v >= 1)
                {
                    a = v % x;
                    if (a >= 10 && a <= x)
                    {
                        char c = (char)(a + 55);
                        b[i] = c.ToString();
                    }
                    else
                        b[i] = a.ToString();
                    i++;
                    v = v / x;

                }
                Console.WriteLine();
                for (i = (b.Length - 1); i >= 0; i--)
                {
                    Console.Write(b[i]);
                }
                Console.WriteLine();
            }

        }

    }
}
