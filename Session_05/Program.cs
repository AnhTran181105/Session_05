using System.Security.Cryptography;

internal class Session_05
{
    public static void Main()
    {
        //Session_05_Q1(6,8,9);
        Console.Write("Nhap chuoi ky tu:");
        string n=Console.ReadLine();
        //Session_05_Q2(a);
        //Session_05_Q3(a);
        //Session_05_Q5(n);
        Session_05_Q6(n);
    }
   
    public static int Session_05_Q1(int a, int b, int c)
    {
        if (a > b)
        {
            if (a > c) { Console.WriteLine("a la so lon nhat"); }
            else
            {

                Console.WriteLine("c la so lon nhat");
            }
        }
        else
        {
            if (b > c) { Console.WriteLine("b la so lon nhat"); }
            else
            {
                Console.WriteLine("c la so lon nhat");
            }

        }
        return 0;
    }
    public static int Session_05_Q2(int n)
    {
        int s = 1;
        for (int i = 1;i<=n;i++)
        {
            s = s * i;
        }
        Console.WriteLine($"Giai thua={s}");
        return 0;
    }
    public static int Session_05_Q3(int n)
    {
        for (int i=2;i<=Math.Sqrt(n);i++)
        {
            if (n%i==0)
            {
                Console.WriteLine($"{n} Khong phai so nguyen to");
                return 0;
            }
        }
        Console.WriteLine($"{n} la so nguyen to");
        return 0;
    }
    public static int Session_05_Q4(int n)
    {
        int i = 0;
       int[] a = new int[100000000];
        int s = 2;
        for ( i=2;i<=n;i++)
        {
            if (a[2]==0)
            {
                for (int j=2;i*j<=n;j++)
                {
                    a[i * j] = 1;
                }
            }
        }
        Console.Write($"Cac so nguyen to be hon {n}:");
        for ( i=2;i<=n;i++)
        {
            if (a[i] == 0)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine($"{n} so nguyen to dau tien:");
         i=2;
        while (i < n)
        {
            if (a[s] == 0)
            {
                Console.Write($"{s}");
                s++;
                i++;
            }
            else { s++; }
        }
        
        return 0;
    }
    public static int Session_05_Q5(int n)
    {
        int uoc = 0;
        int tong = 0;
        for (int i=1;i<=Math.Sqrt(n);i++)
        {
            if(n%i==0)
            {
                tong = tong+ i + n / i;
            }
        }
        if (tong == 2 * n) { Console.WriteLine($"{n} la so hoan hao"); }
        Console.Write("Cac so hoan hao be hon 1000 la: ");
        for (int i = 1;i< 1000; i++)
        {
            tong = 0;
            for ( uoc = 1; uoc <= Math.Sqrt(i); uoc++)
            {
                if (i % uoc == 0)
                {
                    tong = tong+ uoc + i / uoc;
                }
            }
            if (tong == 2 * i) Console.Write($"{i} ");
        }
        return 0;
    }
    public static string Session_05_Q6(string n)
    { 
        int so_ky_tu = 0;
        n= n.ToLower();
        for (int i = 97; i <= 122; i++)
        {
            if (n.Contains((char)i))
            {
                so_ky_tu++;
            }
        }
        if (so_ky_tu == 26)
        {
            Console.WriteLine("Day la chuoi pangram");
        }
        else
        {
            Console.WriteLine("Day khong phai la chuoi pangram");
        }
        return n ;
    }
}

  
