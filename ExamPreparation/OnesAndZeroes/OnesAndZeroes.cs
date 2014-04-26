using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string b = Convert.ToString(n, 2).PadLeft(16, '0');
        string p = b.Substring(Math.Max(0, b.Length - 16));
        //Console.WriteLine(b);
        //Console.WriteLine(p);
        for (int i = 0; i < p.Length - 1; i++)
        {
            if (p[i] == '1')
            {
                Console.Write(".#..");
            }
            else if (p[i] == '0')
            {
                Console.Write("###.");
            }
        }
        if (p[p.Length - 1] == '1')
        {
            Console.Write(".#.");
        }
        else if (p[p.Length - 1] == '0')
        {
            Console.Write("###");
        }
        Console.WriteLine();

        // second row
        for (int i = 0; i < p.Length - 1; i++)
        {
            if (p[i] == '1')
            {
                Console.Write("##..");
            }
            else if (p[i] == '0')
            {
                Console.Write("#.#.");
            }
        }
        if (p[p.Length - 1] == '1')
        {
            Console.Write("##.");
        }
        else if (p[p.Length - 1] == '0')
        {
            Console.Write("#.#");
        }
        Console.WriteLine();

        // third row
        for (int i = 0; i < p.Length - 1; i++)
        {
            if (p[i] == '1')
            {
                Console.Write(".#..");
            }
            else if (p[i] == '0')
            {
                Console.Write("#.#.");
            }
        }
        if (p[p.Length - 1] == '1')
        {
            Console.Write(".#.");
        }
        else if (p[p.Length - 1] == '0')
        {
            Console.Write("#.#");
        }
        Console.WriteLine();

        // forth row
        for (int i = 0; i < p.Length - 1; i++)
        {
            if (p[i] == '1')
            {
                Console.Write(".#..");
            }
            else if (p[i] == '0')
            {
                Console.Write("#.#.");
            }
        }
        if (p[p.Length - 1] == '1')
        {
            Console.Write(".#.");
        }
        else if (p[p.Length - 1] == '0')
        {
            Console.Write("#.#");
        }
        Console.WriteLine();

        // fifth row
        for (int i = 0; i < p.Length - 1; i++)
        {
            if (p[i] == '1')
            {
                Console.Write("###.");
            }
            else if (p[i] == '0')
            {
                Console.Write("###.");
            }
        }
        if (p[p.Length - 1] == '1')
        {
            Console.Write("###");
        }
        else if (p[p.Length - 1] == '0')
        {
            Console.Write("###");
        }
        Console.WriteLine();
    }
}
