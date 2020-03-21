using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s=Console.ReadLine();
            string d = Console.ReadLine();//заданное слово

            int k;
            string h= Console.ReadLine();//заданное k
            int.TryParse(h, out k);

            Console.WriteLine($"{s}");
            string[] w = s.Split(' ');
            List<string> l = new List<string>(w);
         
            int c = 0;
          
            for(int i=0;i<l.Count;i++) {
                if (l[i]==d) c++;
            }
            Console.WriteLine($"Колилчество:{c}");
            

            string f = "";
            if (k > 0)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if ((char.IsUpper(l[i][0]) && (k > 0)))
                    {
                        Console.WriteLine($"l[i][0]: {l[i][0]}");
                        k--;
                        f = l[i];
                    }
                }

                Console.WriteLine($"Слово с заглавной буквы: {f}");

            }
            else {
                Console.WriteLine($"некорректный ввод");
            }

            l[l.Count - 2] = d;
            var r = String.Join(" ", l.ToArray());
            Console.WriteLine($"Заменили предпоследнее слово: {r}");





        }
    }
}
