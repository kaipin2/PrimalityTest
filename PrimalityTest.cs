using System.IO;
using System;
using System.Collections.Generic;

class PrimalityTest
{
    public struct Number
    {
        public int number;
        public bool prime;
    }
    static void Main()
    {
        int number = 0;
        Number result = new Number();
        string prime_text = "素数です";
        string Noprime_text = "素数ではありません";
        List<int> PrimeNumber_list = new List<int>();

        Console.WriteLine("素数かどうか判定するプログラムを実行します");
        Console.Write("判定する数字：");
        number = int.Parse(System.Console.ReadLine());
        result = Judge(number, PrimeNumber_list);
        if (result.prime)
        {
            Console.WriteLine(prime_text);
        }
        else
        {
            Console.WriteLine(Noprime_text);
            Console.WriteLine("少なくとも{0}で割り切れます", result.number);
        }
        Console.ReadKey();
    }

    static Number Judge(int num, List<int> list)
    {
        Number re = new Number(); //結果を格納する変数
        bool flag = false; //割り切れるか判定
        int divisor = 0; //割れる数
        int sqrt = (int)Math.Sqrt(num);
        for (int i = 2; i <= sqrt; i++)
        {
            flag = false;
            if (i == 2)
            {
                list.Add(i);
                //Console.WriteLine("Prime Number Add {0}", i);
            }
            else
            {
                foreach (int prime in list)
                {
                    if (i % prime == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    list.Add(i);
                    //Console.WriteLine("Prime Number Add {0}", i);
                }
            }
        }
        flag = true;

        foreach (int prime in list)
        {
            if (num % prime == 0)
            {
                flag = false;
                divisor = prime;
                break;
            }
        }

        //foreach (int x in list) Console.WriteLine("{0}", x);
        re.number = divisor;
        re.prime = flag;
        return re;
    }
}