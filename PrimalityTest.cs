using System.IO;
using System;
using System.Collections.Generic;

class PrimalityTest
{
    static void Main()
    {
        int number = 0;
        bool result;
        string prime_text = "素数です";
        string Noprime_text = "素数ではありません";
        string text;
        List<int> PrimeNumber_list = new List<int>();

        Console.WriteLine("素数かどうか判定するプログラムを実行します");
        Console.Write("判定する数字：");
        number = int.Parse(System.Console.ReadLine());
        result = Judge(number, PrimeNumber_list);
        text = result ? prime_text : Noprime_text;

        Console.WriteLine(text);
        Console.ReadKey();
    }

    static bool Judge(int num, List<int> list)
    {
        bool flag = false; //割り切れるか判定
        for (int i = 2; i < num + 1; i++)
        {
            flag = false;
            if (i == 2)
            {
                list.Add(i);
                Console.WriteLine("Prime Number Add {0}", i);
            }
            else
            {
                foreach (int prime in list)
                {
                    //Console.WriteLine("{0} {1}", i, prime);
                    if (i % prime == 0) flag = true;
                }
                if (!flag)
                {
                    list.Add(i);
                    Console.WriteLine("Prime Number Add {0}", i);
                }
            }
        }
        //foreach (int x in list) Console.WriteLine("{0}", x);
        return list.Contains(num);
    }
}