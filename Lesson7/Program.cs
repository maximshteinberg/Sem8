// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i}";
//     }
//     return result;
// }



// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
//     else return string.Empty;
// }

// System.Console.WriteLine(NumbersFor(0, 10));
// System.Console.WriteLine(NumbersRec(0, 10));


// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 0; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// System.Console.WriteLine(SumFor(10));
// System.Console.WriteLine(SumRec(10));


// int FacFor(int n)
// {
//     int fac = 1;
//     for (int i = 1; i <= n; i++) fac *= i;
//     return fac;
// }


// int FacRec(int n)
// {
//     if (n==1) return 1;
//     else return n*FacRec(n-1);
// }
// System.Console.WriteLine(FacFor(5));
// System.Console.WriteLine(FacRec(5));

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result*=a;
    return result;
}

int PowerRec(int a, int n)
{
 if (n==0) return 1;
 else return PowerRec(a,n-1)*a;   
}
System.Console.WriteLine(PowerFor(2,10));
System.Console.WriteLine(PowerRec(2,10));