using System;
using System.Collections.Generic ;
using System.Linq;


class newArray
{
    public void AnotherwayOfInsert()
    {
        int[] arr = new int[10];
        int i;
        int n = arr.Length;

        for (i = 0; i < n; i++)
        {
            arr[i] = i + 1;

        }
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        int x = 43;


        int pos = 4;


        int[] newarr = new int[n + 1];

        for (i = 0; i < n + 1; i++)
        {
            if (i < n)
                newarr[i] = arr[i];
            else if (i == pos - 1)
                newarr[i] = x;
            else
                newarr[i] = arr[i - 1];
        }


        for (i = 0; i < n + 1; i++)
            Console.Write(newarr[i] + " ");
        Console.WriteLine();
    }
}










